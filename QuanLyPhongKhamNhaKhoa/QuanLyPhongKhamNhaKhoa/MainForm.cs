using Guna.UI2.WinForms;
using QuanLyPhongKhamNhaKhoa.Dao;
using QuanLyPhongKhamNhaKhoa.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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
        
        public User user = new User();
        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetButtonColors();
            uC_NhanVien2.Visible = false;

            btnAvatar.Size = new System.Drawing.Size(50, 50);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 50, 50);
            btnAvatar.Region = new Region(path);
            //btnAvatar.Image = Image.FromFile("../../image/dieutri.png");


            MemoryStream picture = user.Image;
            if (picture != null && picture.Length > 0)
            {
                btnAvatar.Image = Image.FromStream(picture);
            }

            else
            {
                btnAvatar.Image = Image.FromFile(@"..\..\image\logo.png");
            }
            btnAvatar.ImageSize = new System.Drawing.Size(50, 50);
            btnAvatar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            btnAvatar.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            btnAvatar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            
            Guna2Button clickedButton = (Guna2Button)sender;
            clickedButton.FillColor = Color.LightGray;

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

       

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            Guna2Button clickedButton = (Guna2Button)sender;
            clickedButton.FillColor = Color.LightGray;

            uC_BenhNhan1.Visible = true;
            uC_BenhNhan1.BringToFront();
        }

        

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            picBoxNen.BringToFront();
        }

        private void picBoxNen_Click(object sender, EventArgs e)
        {

        }

        

        private void btnDieuTri_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            Guna2Button clickedButton = (Guna2Button)sender;
            clickedButton.FillColor = Color.LightGray;

            uC_DieuTri1.Visible = true;
            uC_DieuTri1.BringToFront();
        }

        private void btnLichHen_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            Guna2Button clickedButton = (Guna2Button)sender;
            clickedButton.FillColor = Color.LightGray;

            uC_LichHen1.Visible = true;
            uC_LichHen1.BringToFront();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            Guna2Button clickedButton = (Guna2Button)sender;
            clickedButton.FillColor = Color.LightGray;
        }
        private void ResetButtonColors()
        {
            btnBenhNhan.FillColor = Color.SteelBlue;
            btnNhanVien.FillColor = Color.SteelBlue;
            btnLichHen.FillColor = Color.SteelBlue;
            btnBaoCao.FillColor = Color.SteelBlue;
            btnDieuTri.FillColor = Color.SteelBlue;


        }

        private void uC_DieuTri1_Load(object sender, EventArgs e)
        {

        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            if(!uC_TuyChonTaiKhoan1.Visible)
            {
                uC_TuyChonTaiKhoan1.user = user;
                uC_TuyChonTaiKhoan1.Visible = true;
            } else
            {
                uC_TuyChonTaiKhoan1.Visible = false;
            }
            
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            Guna2Button clickedButton = (Guna2Button)sender;
            clickedButton.FillColor = Color.LightGray;
        }

        
    }
}
