using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private MemoryStream image;

        public Patients(string patientsID, string fullName, string gender, DateTime birthDate, string persionalID, string phoneNumber, string address, MemoryStream image)
        {
            PatientsID = patientsID;
            FullName = fullName;
            Gender = gender;
            BirthDate = birthDate;
            PersionalID = persionalID;
            PhoneNumber = phoneNumber;
            Address = address;
            Image = image;
        }
        public string PatientsID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string PersionalID { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public MemoryStream Image { get; set; }
    }
}
