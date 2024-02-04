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
    public class StaffDAL
    {
        string dbconnstring = ConfigurationManager.ConnectionStrings["dbconn"].ToString();

        //Get all the Staffs
        public List<Staff> GetAllStaffs()
        {
            List<Staff> StaffList = new List<Staff>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetAllStaff";
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtStaff = new DataTable();
                connection.Open();
                sqlDA.Fill(dtStaff);
                connection.Close();
                foreach (DataRow dr in dtStaff.Rows)
                {
                    StaffList.Add(new Staff
                    {

                        StaffID = Convert.ToInt32(dr["StaffID"]),
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

            return StaffList;
        }

        //Insert Staffs
        public bool InsertStaffs(Staff Staff)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_InsertStaff", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Firstname", Staff.Firstname);
                command.Parameters.AddWithValue("@LastName", Staff.Lastname);
                command.Parameters.AddWithValue("@DOB", Staff.DOB);
                command.Parameters.AddWithValue("@Address", Staff.Address);
                command.Parameters.AddWithValue("@City", Staff.City);
                command.Parameters.AddWithValue("@State", Staff.State);
                command.Parameters.AddWithValue("@Country", Staff.Country);
                command.Parameters.AddWithValue("@Zip", Staff.Zip);
                command.Parameters.AddWithValue("@MobileNumber", Staff.MobileNumber);
                command.Parameters.AddWithValue("@IsActive", Staff.IsActive);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Get Staff By ID
        public List<Staff> GetStaffByID(int StaffID)
        {
            List<Staff> StaffList = new List<Staff>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetStaffByID";
                command.Parameters.AddWithValue("@StaffID", StaffID);
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtStaff = new DataTable();
                connection.Open();
                sqlDA.Fill(dtStaff);
                connection.Close();
                foreach (DataRow dr in dtStaff.Rows)
                {
                    StaffList.Add(new Staff
                    {

                        StaffID = Convert.ToInt32(dr["StaffID"]),
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

            return StaffList;
        }

        //Update Patient By ID
        public bool UpdateStaffs(Staff Staff)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_UpdateStaffByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StaffID", Staff.StaffID);
                command.Parameters.AddWithValue("@Firstname", Staff.Firstname);
                command.Parameters.AddWithValue("@LastName", Staff.Lastname);
                command.Parameters.AddWithValue("@DOB", Staff.DOB);
                command.Parameters.AddWithValue("@Address", Staff.Address);
                command.Parameters.AddWithValue("@City", Staff.City);
                command.Parameters.AddWithValue("@State", Staff.State);
                command.Parameters.AddWithValue("@Country", Staff.Country);
                command.Parameters.AddWithValue("@Zip", Staff.Zip);
                command.Parameters.AddWithValue("@MobileNumber", Staff.MobileNumber);
                command.Parameters.AddWithValue("@IsActive", Staff.IsActive);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Delete Staff By ID
        public bool DeleteStaffs(int StaffID)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_DeleteStaffByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StaffID", StaffID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }
    }
}