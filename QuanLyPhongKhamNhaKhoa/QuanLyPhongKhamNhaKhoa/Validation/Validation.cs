using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa.Validation
{
    class InvalidExistAppointment : Exception
    {
        public InvalidExistAppointment() : base("Đã tồn tại mã cuộc hẹn này!") { }
        public InvalidExistAppointment(string message) : base(message) { }
    }
    class InvalidExistPatients : Exception
    {
        public InvalidExistPatients() : base("Đã tồn tại mã bệnh nhân này!") { }
        public InvalidExistPatients(string message) : base(message) { }
    }
    class InvalidBirthdate : Exception
    {
        public InvalidBirthdate(int age) : base("Tuổi người đăng kí không hợp lệ!\nPhải lớn hơn " + age + " tuổi") { }
    }
    class InvalidEmail : Exception
    {
        public InvalidEmail() : base("Email không hợp lệ!") { }
        public InvalidEmail(string email) : base("Email " + email + " đã tồn tại!") { }
    }
    class InvalidSDT : Exception
    {
        public InvalidSDT() : base("Số điện thoại không hợp lệ!") { }
        public InvalidSDT(string sdt) : base("Số điện thoại " + sdt + " đã tồn tại!") { }
    }
    class InvalidData : Exception
    {
        public InvalidData() : base("Chưa nhập dữ liệu đầy đủ!") { }
    }
    class InvalidName : Exception
    {
        public InvalidName() : base("Họ tên không hợp lệ!") { }
    }
    class InvalidExistUsers : Exception
    {
        public InvalidExistUsers() : base("Đã tồn tại mã người dùng này!") { }
        public InvalidExistUsers(string message) : base(message) { }
    }
    class InvalidPersionalID : Exception
    {
        public InvalidPersionalID() : base("Số CCCD không hợp lệ!") { }
        public InvalidPersionalID(string persionalID) : base("Số CCCD " + persionalID + " đã tồn tại!") { }
    }
}
