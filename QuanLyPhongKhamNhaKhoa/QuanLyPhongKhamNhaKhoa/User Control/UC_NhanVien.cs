
using QuanLyPhongKhamNhaKhoa.Dao;
using QuanLyPhongKhamNhaKhoa.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyPhongKhamNhaKhoa.User_Control
{
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
        }
        UserDao userDao = new UserDao();

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            refesh();
        }
        private void fillGrid(SqlCommand command)
        {
            try
            {
                dataUser.ReadOnly = true;
                dataUser.DataSource = userDao.getUsers(command);
                dataUser.AllowUserToAddRows = false;

                // đổi tên cột
                dataUser.Columns["userID"].HeaderText = "Mã nhân viên";
                dataUser.Columns["fullName"].HeaderText = "Họ và tên";
                dataUser.Columns["birthDate"].HeaderText = "Ngày sinh";
                dataUser.Columns["gender"].HeaderText = "Giới tính";
                dataUser.Columns["persionalID"].HeaderText = "CCCD";
                dataUser.Columns["phoneNumber"].HeaderText = "Số điện thoại";
                dataUser.Columns["email"].HeaderText = "Email";
                dataUser.Columns["address"].HeaderText = "Địa chỉ";
                dataUser.Columns["isRole"].HeaderText = "Quyền";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    MessageBox.Show("Chưa nhập dữ liệu đầy đủ!", "Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string userID = txtMaNV.Text.Trim();
                if (!userDao.existUsers(userID))
                {
                    MessageBox.Show("Không tồn tại người dùng có mã nhân viên này!", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string fullName = txtHoTen.Text.Trim();
                string persionalID = txtCCCD.Text.Trim();
                string phone = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                string address = txtDiaChi.Text.Trim();

                SqlCommand command = new SqlCommand("SELECT persionalID, phoneNumber, email FROM Users WHERE userID=@userID");
                command.Parameters.Add("@userID", SqlDbType.VarChar).Value = userID;
                DataTable table = userDao.getUsers(command);
                string check_persionalID="";
                string check_phone="";
                string check_email="";
                if (table.Rows.Count > 0)
                {
                    check_persionalID = table.Rows[0]["persionalID"].ToString().Trim();
                    check_phone = table.Rows[0]["phoneNumber"].ToString().Trim();
                    check_email = table.Rows[0]["email"].ToString().Trim();
                }

                if (!Regex.IsMatch(fullName, @"^[\p{L}\s]+$"))
                {
                    MessageBox.Show("Họ tên không hợp lệ!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(persionalID, @"^\d{12}$"))
                {
                    MessageBox.Show("Số CCCD không hợp lệ!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(!check_persionalID.Equals(persionalID))
                {
                    if (userDao.existPersionalIDUsers(persionalID))
                    {
                        MessageBox.Show("Số CCCD đã tồn tại!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (!Regex.IsMatch(phone, @"^0\d{9}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(check_phone != phone)
                {
                    if (userDao.existPhoneUsers(phone))
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Email không hợp lệ!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(check_email != email)
                {
                    if (userDao.existEmailUsers(email))
                    {
                        MessageBox.Show("Email đã tồn tại!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                int born_year = dateTimePickerNgSinh.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 22))
                {
                    MessageBox.Show("Tuổi người dùng phải lớn hơn 22", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime birthDate = dateTimePickerNgSinh.Value;

                string gender = "Nam";
                if (rbFemale.Checked)
                {
                    gender = "Nữ";
                }

                string chucVu = "ASSISTANT";
                if (radNhaSi.Checked)
                {
                    chucVu = "DENTIST";
                }
                if (radAdmin.Checked)
                {
                    chucVu = "ADMIN";
                }

                User user = new User(userID, fullName, birthDate, gender, persionalID, phone, email, address, chucVu, "");
                if (userDao.updateUsers(user))
                {
                    MessageBox.Show("Cập nhật người dùng thành công!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refesh();
                    reset();
                }
                else
                {
                    MessageBox.Show("Cập nhật người dùng thất bại!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    MessageBox.Show("Chưa nhập dữ liệu đầy đủ!", "Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string userId = txtMaNV.Text.Trim();
                if (userDao.existUsers(userId))
                {
                    MessageBox.Show("Người dùng đã tồn tại!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string fullName = txtHoTen.Text.Trim();
                string persionalID = txtCCCD.Text.Trim();
                string phone = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                string address = txtDiaChi.Text.Trim();
                if (!Regex.IsMatch(fullName, @"^[\p{L}\s]+$"))
                {
                    MessageBox.Show("Họ tên không hợp lệ!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(persionalID, @"^\d{12}$"))
                {
                    MessageBox.Show("Số CCCD không hợp lệ!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (userDao.existPersionalIDUsers(persionalID))
                {
                    MessageBox.Show("Số CCCD đã tồn tại!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(phone, @"^0\d{9}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (userDao.existPhoneUsers(phone))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Email không hợp lệ!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (userDao.existEmailUsers(email))
                {
                    MessageBox.Show("Email đã tồn tại!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int born_year = dateTimePickerNgSinh.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 22))
                {
                    MessageBox.Show("Tuổi người dùng phải lớn hơn 22", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime birthDate = dateTimePickerNgSinh.Value;
                
                string gender = "Nam";
                if (rbFemale.Checked)
                {
                    gender = "Nữ";
                }

                string chucVu = "ASSISTANT";
                if (radNhaSi.Checked)
                {
                    chucVu = "DENTIST";
                }
                if (radAdmin.Checked)
                {
                    chucVu = "ADMIN";
                }

                //tạo mã user tự động
                string userID = userDao.taoMaUsers(chucVu);

                // tạo password tự động
                string password = userDao.taoPassword();

                User user = new User(userID, fullName, birthDate, gender, persionalID, phone, email, address, chucVu, password);
                if (userDao.insertUsers(user))
                {
                    MessageBox.Show("Thêm người dùng thành công!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refesh();
                    reset();
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        bool verif()
        {
            if ((txtHoTen.Text.Trim() == "")
                        || (dateTimePickerNgSinh.Text.Trim() == "")
                        || (txtCCCD.Text.Trim() == "")
                        || (txtSDT.Text.Trim() == "")
                        || (txtEmail.Text.Trim() == "")
                        || (txtDiaChi.Text.Trim() == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset();
            refesh();
        }
        public void reset()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtCCCD.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtTimKiem.Text = "";
            rbMale.Checked = true;
            radNhanVien.Checked = true;
            dateTimePickerNgSinh.Value = DateTime.Now;
        }
        public void refesh()
        {
            SqlCommand command = new SqlCommand("SELECT userID, fullName, birthDate, gender, persionalID, phoneNumber, email, isRole, address FROM Users");
            fillGrid(command);
        }
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = txtMaNV.Text.Trim();
                if (!userDao.existUsers(userId))
                {
                    MessageBox.Show("Bạn chưa chọn người dùng cần xoá!", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //coi chừng khoá ngoại
                if(MessageBox.Show("Bạn có chắc chắn muốn xoá người dùng không?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (userDao.deleteUsers(userId))
                    {
                        MessageBox.Show("Xoá người dùng thành công!", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refesh();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Xoá người dùng thất bại!", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataUser_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaNV.Text = dataUser.CurrentRow.Cells["userID"].Value.ToString();
                txtHoTen.Text = dataUser.CurrentRow.Cells["fullName"].Value.ToString();
                dateTimePickerNgSinh.Value = (DateTime)dataUser.CurrentRow.Cells["birthDate"].Value;
                if (dataUser.CurrentRow.Cells["gender"].Value.ToString().Trim() == "Nữ")
                {
                    rbFemale.Checked = true;
                }
                else rbMale.Checked = true;

                if (dataUser.CurrentRow.Cells["isRole"].Value.ToString().Trim() == "ADMIN")
                {
                    radAdmin.Checked = true;
                }
                if (dataUser.CurrentRow.Cells["isRole"].Value.ToString().Trim() == "ASSISTANT")
                {
                    radNhanVien.Checked = true;
                }
                if (dataUser.CurrentRow.Cells["isRole"].Value.ToString().Trim() == "DENTIST")
                {
                    radNhaSi.Checked = true;
                }

                txtCCCD.Text = dataUser.CurrentRow.Cells["persionalID"].Value.ToString();
                txtSDT.Text = dataUser.CurrentRow.Cells["phoneNumber"].Value.ToString();
                txtEmail.Text = dataUser.CurrentRow.Cells["email"].Value.ToString();
                txtDiaChi.Text = dataUser.CurrentRow.Cells["address"].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timKiem();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }
        public void timKiem()
        {
            SqlCommand command = new SqlCommand("SELECT userID, fullName, birthDate, gender, persionalID, phoneNumber, email, isRole, address " +
                "FROM Users WHERE userID LIKE @timKiem OR fullName LIKE @timKiem OR persionalID LIKE @timKiem OR phoneNumber LIKE @timKiem OR email LIKE @timKiem OR isRole LIKE @timKiem");
            command.Parameters.Add("@timKiem", SqlDbType.NVarChar).Value = "%" + txtTimKiem.Text.Trim() + "%";
            fillGrid(command);
        }
    }
}
