using QuanLyPhongKhamNhaKhoa.Models;
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


        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            /*this.userTableAdapter.Fill(this.dentalClinicDataSetDSNV.User);
            SqlCommand cmd = new SqlCommand("Select userID, fullName, birthDate, gender, personalID, phoneNumber, address, isDoctor from [User]");
            fillDataGrid(cmd);*/

        }
        public void fillDataGrid(SqlCommand cmd)
        {
            dataUser.ReadOnly = true;
            dataUser.RowTemplate.Height = 50;
            dataUser.DataSource = user.getUser(cmd);
            dataUser.AllowUserToAddRows = false;
        }


    }
}
