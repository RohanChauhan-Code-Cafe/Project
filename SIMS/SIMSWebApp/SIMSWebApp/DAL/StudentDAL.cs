using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SIMSWebApp.Models;


namespace SIMSWebApp.DAL
{
    public class StudentDAL
    {
        string dbconnstring = ConfigurationManager.ConnectionStrings["dbconn"].ToString();

        //Get all the students
        public List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetAllStudent";
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtStudent = new DataTable();
                connection.Open();
                sqlDA.Fill(dtStudent);
                connection.Close();
                foreach (DataRow dr in dtStudent.Rows)
                {
                    studentList.Add(new Student
                    {

                        StudentID = Convert.ToInt32(dr["StudentID"]),
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

            return studentList;
        }

        //Insert students
        public bool InsertStudents(Student student)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_InsertStudent", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Firstname", student.Firstname);
                command.Parameters.AddWithValue("@LastName", student.Lastname);
                command.Parameters.AddWithValue("@DOB", student.DOB);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@City", student.City);
                command.Parameters.AddWithValue("@State", student.State);
                command.Parameters.AddWithValue("@Country", student.Country);
                command.Parameters.AddWithValue("@Zip", student.Zip);
                command.Parameters.AddWithValue("@MobileNumber", student.MobileNumber);
                command.Parameters.AddWithValue("@IsActive", student.IsActive);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Get Student By ID
        public List<Student> GetStudentByID(int StudentID)
        {
            List<Student> studentList = new List<Student>();
            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sproc_GetStudentByID";
                command.Parameters.AddWithValue("@StudentID", StudentID);
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtStudent = new DataTable();
                connection.Open();
                sqlDA.Fill(dtStudent);
                connection.Close();
                foreach (DataRow dr in dtStudent.Rows)
                {
                    studentList.Add(new Student
                    {

                        StudentID = Convert.ToInt32(dr["StudentID"]),
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

            return studentList;
        }

        //Update Student By ID
        public bool UpdateStudents(Student student)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_UpdateStudentByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", student.StudentID);
                command.Parameters.AddWithValue("@Firstname", student.Firstname);
                command.Parameters.AddWithValue("@LastName", student.Lastname);
                command.Parameters.AddWithValue("@DOB", student.DOB);
                command.Parameters.AddWithValue("@Address", student.Address);
                command.Parameters.AddWithValue("@City", student.City);
                command.Parameters.AddWithValue("@State", student.State);
                command.Parameters.AddWithValue("@Country", student.Country);
                command.Parameters.AddWithValue("@Zip", student.Zip);
                command.Parameters.AddWithValue("@MobileNumber", student.MobileNumber);
                command.Parameters.AddWithValue("@IsActive", student.IsActive);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

        //Delete Student By ID
        public bool DeleteStudents(int StuentID)
        {

            using (SqlConnection connection = new SqlConnection(dbconnstring))
            {
                SqlCommand command = new SqlCommand("sproc_DeleteStudentByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentID", StuentID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return true;
        }

    }

}