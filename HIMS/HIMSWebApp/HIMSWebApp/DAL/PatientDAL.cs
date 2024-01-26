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
    public class PatientDAL
    {
        string dbconnstring = ConfigurationManager.ConnectionStrings["dbconn"].ToString();

        //Get all the Patients
        public List<Patient> GetAllPatients()
        {
            List<Patient> PatientList = new List<Patient>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetAllPatient";
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtPatient = new DataTable();
                connection.Open();
                sqlDA.Fill(dtPatient);
                connection.Close();
                foreach (DataRow dr in dtPatient.Rows)
                {
                    PatientList.Add(new Patient
                    {

                        PatientID = Convert.ToInt32(dr["PatientID"]),
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

            return PatientList;
        }

        //Insert Patients
        public bool InsertPatients(Patient Patient)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_InsertPatient", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Firstname", Patient.Firstname);
                command.Parameters.AddWithValue("@LastName", Patient.Lastname);
                command.Parameters.AddWithValue("@DOB", Patient.DOB);
                command.Parameters.AddWithValue("@Address", Patient.Address);
                command.Parameters.AddWithValue("@City", Patient.City);
                command.Parameters.AddWithValue("@State", Patient.State);
                command.Parameters.AddWithValue("@Country", Patient.Country);
                command.Parameters.AddWithValue("@Zip", Patient.Zip);
                command.Parameters.AddWithValue("@MobileNumber", Patient.MobileNumber);
                command.Parameters.AddWithValue("@IsActive", Patient.IsActive);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Get Patient By ID
        public List<Patient> GetPatientByID(int PatientID)
        {
            List<Patient> PatientList = new List<Patient>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetPatientByID";
                command.Parameters.AddWithValue("@PatientID", PatientID);
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtPatient = new DataTable();
                connection.Open();
                sqlDA.Fill(dtPatient);
                connection.Close();
                foreach (DataRow dr in dtPatient.Rows)
                {
                    PatientList.Add(new Patient
                    {

                        PatientID = Convert.ToInt32(dr["PatientID"]),
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

            return PatientList;
        }

        //Update Patient By ID
        public bool UpdatePatients(Patient Patient)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_UpdatePatientByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatientID", Patient.PatientID);
                command.Parameters.AddWithValue("@Firstname", Patient.Firstname);
                command.Parameters.AddWithValue("@LastName", Patient.Lastname);
                command.Parameters.AddWithValue("@DOB", Patient.DOB);
                command.Parameters.AddWithValue("@Address", Patient.Address);
                command.Parameters.AddWithValue("@City", Patient.City);
                command.Parameters.AddWithValue("@State", Patient.State);
                command.Parameters.AddWithValue("@Country", Patient.Country);
                command.Parameters.AddWithValue("@Zip", Patient.Zip);
                command.Parameters.AddWithValue("@MobileNumber", Patient.MobileNumber);
                command.Parameters.AddWithValue("@IsActive", Patient.IsActive);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Delete Patient By ID
        public bool DeletePatients(int StuentID)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_DeletePatientByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatientID", StuentID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }
    }
}