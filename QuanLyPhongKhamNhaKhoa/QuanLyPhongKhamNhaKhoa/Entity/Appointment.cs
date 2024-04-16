using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa.Entity
{
    public class Appointment
    {
        private string appointmentID;
        private string patientsID;
        private string userID;
        private DateTime appointmentDate;
        private DateTime startTime;
        private DateTime endTime;
        private string status;

        public Appointment(string appointmentID, string patientsID, string userID, DateTime appointmentDate, DateTime startTime, DateTime endTime, string status)
        {
            this.appointmentID = appointmentID;
            this.patientsID = patientsID;
            this.userID = userID;
            this.appointmentDate = appointmentDate;
            this.startTime = startTime;
            this.endTime = endTime;
            this.status = status;
        }
        public string AppointmentID { get; set; }
        public string PatientsID { get; set; }
        public string UserID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
    }
}
