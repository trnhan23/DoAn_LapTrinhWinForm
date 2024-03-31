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
        private TimeSpan startTime;
        private TimeSpan endTime;
        private bool status;

        public string AppointmentID { get { return appointmentID; } set {appointmentID = value;} }
        public string PatientsID { get { return patientsID; } set {patientsID = value;} }
        public string UserID { get { return userID; } set {userID = value;} }
        public DateTime AppointmentDate { get { return appointmentDate; } set {appointmentDate = value;} }
        public TimeSpan StartTime { get { return startTime; } set {startTime = value;} }
        public TimeSpan EndTime { get { return endTime; } set {endTime = value;} }
        public bool Status { get { return status; } set {status = value;} }
    }
}
