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
        private string email;
        private string address;
        private string isRole;
        private string password;

        public User(string userID, string fullName, DateTime birthDate, string gender, string persionalID, string phoneNumber, string email, string address, string isRole, string password)
        {
            UserID = userID;
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
            PersionalID = persionalID;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            IsRole = isRole;
            Password = password;
        }
        public string UserID { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string PersionalID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string IsRole { get; set; }
        public string Password { get; set; }

        internal void insertUsers(User user)
        {
            throw new NotImplementedException();
        }
    }
}
