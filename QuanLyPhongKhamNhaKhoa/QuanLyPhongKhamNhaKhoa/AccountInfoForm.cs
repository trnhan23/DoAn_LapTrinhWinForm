using QuanLyPhongKhamNhaKhoa.Dao;
using QuanLyPhongKhamNhaKhoa.Entity;
using QuanLyPhongKhamNhaKhoa.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKhamNhaKhoa
{
    public partial class AccountInfoForm : Form
    {
        UserDao userDao = new UserDao();
        public string userID;
        User user;
        public AccountInfoForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool verif()
        {
            if ((txtHoTen.Text.Trim() == "")
                        || (dateTimePickerNgSinh.Text.Trim() == "")
                        || (txtCCCD.Text.Trim() == "")
                        || (txtSDT.Text.Trim() == "")
                        || (txtEmail.Text.Trim() == "")
                        || (picBoxImage.Image == null)
                        || (txtDiaChi.Text.Trim() == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        public void capNhatUsers()
        {
            try
            {
                if (verif())
                {
                    throw new InvalidData();
                }
                string userID = lblMaNV.Text.Trim();
                if (!userDao.existUsers(userID))
                {
                    throw new InvalidExistUsers("Không tồn tại người dùng có mã nhân viên này!");
                }
                string fullName = txtHoTen.Text.Trim();
                string persionalID = txtCCCD.Text.Trim();
                string phone = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                string address = txtDiaChi.Text.Trim();

                SqlCommand command = new SqlCommand("SELECT persionalID, phoneNumber, email FROM Users WHERE userID=@userID");
                command.Parameters.Add("@userID", SqlDbType.VarChar).Value = userID;
                DataTable table = userDao.getUsers(command);
                string check_persionalID = "";
                string check_phone = "";
                string check_email = "";
                if (table.Rows.Count > 0)
                {
                    check_persionalID = table.Rows[0]["persionalID"].ToString().Trim();
                    check_phone = table.Rows[0]["phoneNumber"].ToString().Trim();
                    check_email = table.Rows[0]["email"].ToString().Trim();
                }

                if (!Regex.IsMatch(fullName, @"^[\p{L}\s]+$"))
                {
                    throw new InvalidName();
                }
                if (!Regex.IsMatch(persionalID, @"^\d{12}$"))
                {
                    throw new InvalidPersionalID();
                }
                if (!check_persionalID.Equals(persionalID))
                {
                    if (userDao.existPersionalIDUsers(persionalID))
                    {
                        throw new InvalidPersionalID(persionalID);
                    }
                }
                if (!Regex.IsMatch(phone, @"^0\d{9}$"))
                {
                    throw new InvalidSDT();
                }
                if (check_phone != phone)
                {
                    if (userDao.existPhoneUsers(phone))
                    {
                        throw new InvalidSDT(phone);
                    }
                }
                if (!IsValidEmail(email))
                {
                    throw new InvalidEmail();
                }
                if (check_email != email)
                {
                    if (userDao.existEmailUsers(email))
                    {
                        throw new InvalidEmail(email);
                    }
                }
                int born_year = dateTimePickerNgSinh.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 22))
                {
                    throw new InvalidBirthdate(22);
                }
                DateTime birthDate = dateTimePickerNgSinh.Value;

                string gender = "Nam";
                if (rbFemale.Checked)
                {
                    gender = "Nữ";
                }
                string chucVu = lblChucvu.Text;
                MemoryStream pic = new MemoryStream();
                picBoxImage.Image.Save(pic, picBoxImage.Image.RawFormat);

                string passWord = user.Password.Trim();

                User userNew = new User(userID, fullName, birthDate, gender, persionalID, phone, email, address, chucVu, passWord, pic);
                if (userDao.updateUsers(userNew))
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thành công!", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //hiển thị các dữ liệu đã được chỉnh sủa lên textbox
                    loadDuLieu(userNew);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thất bại!", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AccountInfoForm_Load(object sender, EventArgs e)
        {
            layDuLieu();
        }

        private void layDuLieu()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE userID = @User");
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = userID.Trim();
            user = userDao.getUser(command);
            if (user == null)
            {
                throw new InvalidExistAppointment("Lỗi hiển thị thông tin");
            }
            loadDuLieu(user);
        }

        private void loadDuLieu(User user)
        {
            lblMaNV.Text = user.UserID;
            lblChucvu.Text = user.IsRole;
            txtHoTen.Text = user.FullName;
            txtCCCD.Text = user.PersionalID;
            txtDiaChi.Text = user.Address;
            txtEmail.Text = user.Email;
            txtSDT.Text = user.PhoneNumber;
            rbMale.Checked = true;
            dateTimePickerNgSinh.Value = user.BirthDate;
            if (user.Gender.Equals("Nữ"))
            {
                rbFemale.Checked = true;
            }

            MemoryStream picture = user.Image;
            if (picture != null && picture.Length > 0)
            {
                byte[] pic = picture.ToArray();
                picBoxImage.Image = Image.FromStream(new MemoryStream(pic));
            }
            else
            {
                picBoxImage.Image = Image.FromFile(@"..\..\image\user.jpg");
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            capNhatUsers();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
