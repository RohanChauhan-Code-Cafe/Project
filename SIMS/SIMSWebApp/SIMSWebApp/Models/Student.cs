using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIMSWebApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string MobileNumber { get; set; }
        public bool IsActive { get; set; }
    }
}