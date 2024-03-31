using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa.Entity
{
    public class Patients
    {
        private string patientsID;
        private string fullName;
        private string gender;
        private DateTime birthDate;
        private string persionalID;
        private string phoneNumber;
        private string address;

        public string PatientsID { get { return patientsID; } set { patientsID = value; } }
        public string FullName { get { return fullName; } set { fullName = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public DateTime BirthDate { get { return birthDate; } set {birthDate = value; } }
        public string PersionalID { get { return persionalID; } set { persionalID = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Address { get { return address; } set { address = value; } }
    }
}
