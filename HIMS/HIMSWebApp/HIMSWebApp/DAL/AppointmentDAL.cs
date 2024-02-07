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
    public class AppointmentDAL
    {
        string dbconnstring = ConfigurationManager.ConnectionStrings["dbconn"].ToString();

        //Get all the Appointments
        public List<Appointment> GetAllAppointments()
        {
            List<Appointment> AppointmentList = new List<Appointment>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetAllAppointment";
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtAppointment = new DataTable();
                connection.Open();
                sqlDA.Fill(dtAppointment);
                connection.Close();
                foreach (DataRow dr in dtAppointment.Rows)
                {
                    AppointmentList.Add(new Appointment
                    {

                        AppointmentID = Convert.ToInt32(dr["AppointmentID"]),
                        DoctorID = Convert.ToInt32(dr["DoctorID"]),
                        PatientID = Convert.ToInt32(dr["PatientID"]),
                        DateOfAppointment = Convert.ToDateTime(dr["DateOfAppointment"]),
                      
                    });
                }

            }

            return AppointmentList;
        }

        //Insert Appointments
        public bool InsertAppointments(Appointment Appointment)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_InsertAppointment", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DoctorID", Appointment.DoctorID);
                command.Parameters.AddWithValue("@PatientID", Appointment.PatientID);
                command.Parameters.AddWithValue("@DateOfAppointment", Appointment.DateOfAppointment);
               

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Get Appointment By ID
        public List<Appointment> GetAppointmentByID(int AppointmentID)
        {
            List<Appointment> AppointmentList = new List<Appointment>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetAppointmentByID";
                command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtAppointment = new DataTable();
                connection.Open();
                sqlDA.Fill(dtAppointment);
                connection.Close();
                foreach (DataRow dr in dtAppointment.Rows)
                {
                    AppointmentList.Add(new Appointment
                    {

                        AppointmentID = Convert.ToInt32(dr["AppointmentID"]),
                        DoctorID = Convert.ToInt32(dr["DoctorID"]),
                        PatientID = Convert.ToInt32(dr["PatientID"]),
                        DateOfAppointment = Convert.ToDateTime(dr["DateOfAppointment"]),
                    });
                }

            }

            return AppointmentList;
        }

        //Update Patient By ID
        public bool UpdateAppointments(Appointment Appointment)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_UpdateAppointmentByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentID", Appointment.AppointmentID);
                command.Parameters.AddWithValue("@DoctorID", Appointment.DoctorID);
                command.Parameters.AddWithValue("@PatientID", Appointment.PatientID);
                command.Parameters.AddWithValue("@DateOfAppointment", Appointment.DateOfAppointment);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Delete Appointment By ID
        public bool DeleteAppointments(int AppointmentID)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_DeleteAppointmentByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }
    }
}