using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa.Entity
{
    public class Treatment
    {
        private string treatmentID;
        private string patientsID;
        private string userID;
        private DateTime startDate;
        private DateTime endDate;
        private string treatmentDetail;
        private string advice;

        public string TreatmentID { get { return treatmentID; } set {treatmentID = value; } }
        public string PatientsID { get { return patientsID; } set {patientsID = value; } }
        public string UserID { get { return userID; } set {userID = value; } }
        public DateTime StartDate { get { return startDate; } set {startDate = value; } }
        public DateTime EndDate { get { return endDate; } set {endDate = value; } }
        public string TreatmentDetail { get { return treatmentDetail; } set {treatmentDetail = value; } }
        public string Advice { get { return advice; } set {advice = value; } }
    }
}
