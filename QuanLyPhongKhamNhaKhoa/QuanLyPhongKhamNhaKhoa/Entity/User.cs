using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa.Entity
{
    public class User
    {
        private string userID;
        private string fullName;
        private DateTime birthDate;
        private string gender;
        private string persionalID;
        private string phoneNumber;
        private string address;
        private bool isDoctor;
        private bool isAdmin;
        private string password;

        public string UserID { get { return userID; } set { userID = value; } }
        public string FullName { get { return fullName; } set { fullName = value; } }
        public DateTime BirthDate { get { return birthDate; } set {birthDate = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string PersionalID { get { return persionalID; } set { persionalID = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Address { get { return address; } set { address = value; } }
        public bool IsDoctor { get { return isDoctor; } set {isDoctor = value; } }
        public bool IsAdmin { get { return isAdmin; } set { isAdmin = value; } }
        public string Password { get { return password; } set { password = value; } }
        
    }
}
