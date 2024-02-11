using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using HIMSWebApp.Models;

namespace HIMSWebApp.DAL
{
    public class SpecialityDAL
    {
        string dbconnstring = ConfigurationManager.ConnectionStrings["dbconn"].ToString();

        //Get all the Specialitys
        public List<Speciality> GetAllSpecialitys()
        {
            List<Speciality> SpecialityList = new List<Speciality>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetAllSpeciality";
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtSpeciality = new DataTable();
                connection.Open();
                sqlDA.Fill(dtSpeciality);
                connection.Close();
                foreach (DataRow dr in dtSpeciality.Rows)
                {
                    SpecialityList.Add(new Speciality
                    {

                        SpecialityID = Convert.ToInt32(dr["SpecialityID"]),
                        Description = dr["Description"].ToString(),

                    });
                }

            }

            return SpecialityList;
        }

        //Insert Specialitys
        public bool InsertSpecialitys(Speciality Speciality)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_InsertSpeciality", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Description", Speciality.Description);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Get Speciality By ID
        public List<Speciality> GetSpecialityByID(int SpecialityID)
        {
            List<Speciality> SpecialityList = new List<Speciality>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetSpecialityByID";
                command.Parameters.AddWithValue("@SpecialityID", SpecialityID);
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtSpeciality = new DataTable();
                connection.Open();
                sqlDA.Fill(dtSpeciality);
                connection.Close();
                foreach (DataRow dr in dtSpeciality.Rows)
                {
                    SpecialityList.Add(new Speciality
                    {

                        SpecialityID = Convert.ToInt32(dr["SpecialityID"]),
                        Description = dr["Description"].ToString(),
                    });
                }

            }

            return SpecialityList;
        }

        //Update Patient By ID
        public bool UpdateSpecialitys(Speciality Speciality)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_UpdateSpecialityByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SpecialityID", Speciality.SpecialityID);
                command.Parameters.AddWithValue("@Description", Speciality.Description);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Delete Speciality By ID
        public bool DeleteSpecialitys(int SpecialityID)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_DeleteSpecialityByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SpecialityID", SpecialityID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }
    }
}