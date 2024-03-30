using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKhamNhaKhoa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            uC_NhanVien2.Visible = false;
            //btnNhanVien.PerformClick();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            uC_NhanVien2.Visible = true;
            uC_NhanVien2.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            uC_BenhNhan1.Visible = true;
            uC_BenhNhan1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_LichHen1.Visible = true;
            uC_LichHen1.BringToFront();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            picBoxNen.BringToFront();
        }

        private void picBoxNen_Click(object sender, EventArgs e)
        {

        }
    }
}
