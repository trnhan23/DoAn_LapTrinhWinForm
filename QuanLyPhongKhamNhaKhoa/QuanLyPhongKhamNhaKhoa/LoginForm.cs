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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKhamNhaKhoa
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        UserDao userDao = new UserDao();
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLConnectionData mydb = new SQLConnectionData();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE userID = @User AND password = @Pass", mydb.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = txtTenDangNhap.Text.Trim();
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtMatKhau.Text.Trim();

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                User user = userDao.getUser(command);
                MainForm mainForm = new MainForm();
                mainForm.user = user;
                this.Hide();
                mainForm.ShowDialog(); 
                
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu sai.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
