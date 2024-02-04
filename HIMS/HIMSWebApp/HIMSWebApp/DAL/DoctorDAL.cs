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
    public class DoctorDAL
    {
        string dbconnstring = ConfigurationManager.ConnectionStrings["dbconn"].ToString();

        //Get all the Doctors
        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> DoctorList = new List<Doctor>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetAllDoctor";
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtDoctor = new DataTable();
                connection.Open();
                sqlDA.Fill(dtDoctor);
                connection.Close();
                foreach (DataRow dr in dtDoctor.Rows)
                {
                    DoctorList.Add(new Doctor
                    {

                        DoctorID = Convert.ToInt32(dr["DoctorID"]),
                        Firstname = dr["Firstname"].ToString(),
                        Lastname = dr["LastName"].ToString(),
                        DOB = Convert.ToDateTime(dr["DOB"]),
                        Address = dr["Address"].ToString(),
                        City = dr["City"].ToString(),
                        State = dr["State"].ToString(),
                        Country = dr["Country"].ToString(),
                        Zip = dr["Zip"].ToString(),
                        MobileNumber = dr["MobileNumber"].ToString(),
                        IsActive = Convert.ToBoolean(dr["IsActive"])
                    });
                }

            }

            return DoctorList;
        }

        //Insert Doctors
        public bool InsertDoctors(Doctor Doctor)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_InsertDoctor", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Firstname", Doctor.Firstname);
                command.Parameters.AddWithValue("@LastName", Doctor.Lastname);
                command.Parameters.AddWithValue("@DOB", Doctor.DOB);
                command.Parameters.AddWithValue("@Address", Doctor.Address);
                command.Parameters.AddWithValue("@City", Doctor.City);
                command.Parameters.AddWithValue("@State", Doctor.State);
                command.Parameters.AddWithValue("@Country", Doctor.Country);
                command.Parameters.AddWithValue("@Zip", Doctor.Zip);
                command.Parameters.AddWithValue("@MobileNumber", Doctor.MobileNumber);
                command.Parameters.AddWithValue("@IsActive", Doctor.IsActive);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Get Doctor By ID
        public List<Doctor> GetDoctorByID(int DoctorID)
        {
            List<Doctor> DoctorList = new List<Doctor>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetDoctorByID";
                command.Parameters.AddWithValue("@DoctorID", DoctorID);
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtDoctor = new DataTable();
                connection.Open();
                sqlDA.Fill(dtDoctor);
                connection.Close();
                foreach (DataRow dr in dtDoctor.Rows)
                {
                    DoctorList.Add(new Doctor
                    {

                        DoctorID = Convert.ToInt32(dr["DoctorID"]),
                        Firstname = dr["Firstname"].ToString(),
                        Lastname = dr["LastName"].ToString(),
                        DOB = Convert.ToDateTime(dr["DOB"]),
                        Address = dr["Address"].ToString(),
                        City = dr["City"].ToString(),
                        State = dr["State"].ToString(),
                        Country = dr["Country"].ToString(),
                        Zip = dr["Zip"].ToString(),
                        MobileNumber = dr["MobileNumber"].ToString(),
                        IsActive = Convert.ToBoolean(dr["IsActive"])
                    });
                }

            }

            return DoctorList;
        }

        //Update Patient By ID
        public bool UpdateDoctors(Doctor Doctor)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_UpdateDoctorByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DoctorID", Doctor.DoctorID);
                command.Parameters.AddWithValue("@Firstname", Doctor.Firstname);
                command.Parameters.AddWithValue("@LastName", Doctor.Lastname);
                command.Parameters.AddWithValue("@DOB", Doctor.DOB);
                command.Parameters.AddWithValue("@Address", Doctor.Address);
                command.Parameters.AddWithValue("@City", Doctor.City);
                command.Parameters.AddWithValue("@State", Doctor.State);
                command.Parameters.AddWithValue("@Country", Doctor.Country);
                command.Parameters.AddWithValue("@Zip", Doctor.Zip);
                command.Parameters.AddWithValue("@MobileNumber", Doctor.MobileNumber);
                command.Parameters.AddWithValue("@IsActive", Doctor.IsActive);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Delete Doctor By ID
        public bool DeleteDoctors(int DoctorID)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_DeleteDoctorByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DoctorID", DoctorID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }
    }
}