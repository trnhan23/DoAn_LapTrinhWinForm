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
        private string startTime;
        private string endTime;
        private string status;

        public Appointment(string appointmentID, string patientsID, string userID, DateTime appointmentDate, string startTime, string endTime, string status)
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
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Status { get; set; }
    }
}
