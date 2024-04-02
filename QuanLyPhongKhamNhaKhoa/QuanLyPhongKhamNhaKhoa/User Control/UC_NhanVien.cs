
using QuanLyPhongKhamNhaKhoa.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKhamNhaKhoa.User_Control
{
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        UserDao user = new UserDao();


        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Users");
            fillGrid(command);
        }


        private void fillGrid(SqlCommand command)
        {
            try
            {
                this.usersTableAdapter.Fill(this.qLNhaKhoaDataSet_User.Users);
                dataUser.ReadOnly = true;
                dataUser.DataSource = user.getUsers(command);
                dataUser.AllowUserToAddRows = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string userID = txtMaNV.Text.Trim();
            string fullName = txtHoTen.Text.Trim();
            DateTime birthDate = dateTimePickerNgSinh.Value;
            string gender = "Male";
            if (rbFemale.Checked)
            {
                gender = "Female";
            }
        }
    }
}
