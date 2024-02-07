using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HIMSWebApp.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public DateTime DateOfAppointment { get; set; }
       
    }
}