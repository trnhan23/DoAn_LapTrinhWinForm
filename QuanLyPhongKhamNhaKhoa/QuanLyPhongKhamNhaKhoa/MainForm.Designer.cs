namespace QuanLyPhongKhamNhaKhoa
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnLichHen = new Guna.UI2.WinForms.Guna2Button();
            this.btnBenhNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.picBoxNen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes3 = new Guna.UI2.WinForms.Guna2Shapes();
            this.uC_LichHen1 = new QuanLyPhongKhamNhaKhoa.User_Control.UC_LichHen();
            this.uC_BenhNhan1 = new QuanLyPhongKhamNhaKhoa.User_Control.UC_BenhNhan();
            this.uC_NhanVien2 = new QuanLyPhongKhamNhaKhoa.User_Control.UC_NhanVien();
            this.uC_NhanVien1 = new QuanLyPhongKhamNhaKhoa.User_Control.UC_NhanVien();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.picBoxNen);
            this.panel3.Controls.Add(this.uC_LichHen1);
            this.panel3.Controls.Add(this.uC_BenhNhan1);
            this.panel3.Controls.Add(this.uC_NhanVien2);
            this.panel3.Controls.Add(this.uC_NhanVien1);
            this.panel3.Location = new System.Drawing.Point(1, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1564, 816);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Controls.Add(this.guna2Button3);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.btnLichHen);
            this.panel2.Controls.Add(this.btnBenhNhan);
            this.panel2.Controls.Add(this.btnNhanVien);
            this.panel2.Location = new System.Drawing.Point(1, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1564, 90);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, -2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(101, 90);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageOffset = new System.Drawing.Point(20, -13);
            this.guna2Button3.ImageSize = new System.Drawing.Size(37, 37);
            this.guna2Button3.Location = new System.Drawing.Point(733, 3);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(160, 94);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.Text = "Báo Cáo";
            this.guna2Button3.TextOffset = new System.Drawing.Point(-8, 20);
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageOffset = new System.Drawing.Point(19, -13);
            this.guna2Button1.ImageSize = new System.Drawing.Size(37, 37);
            this.guna2Button1.Location = new System.Drawing.Point(573, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(160, 94);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Điều trị";
            this.guna2Button1.TextOffset = new System.Drawing.Point(-8, 20);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnLichHen
            // 
            this.btnLichHen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLichHen.BorderColor = System.Drawing.Color.White;
            this.btnLichHen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLichHen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLichHen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichHen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLichHen.FillColor = System.Drawing.Color.SteelBlue;
            this.btnLichHen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichHen.ForeColor = System.Drawing.Color.Black;
            this.btnLichHen.Image = ((System.Drawing.Image)(resources.GetObject("btnLichHen.Image")));
            this.btnLichHen.ImageOffset = new System.Drawing.Point(20, -13);
            this.btnLichHen.ImageSize = new System.Drawing.Size(37, 37);
            this.btnLichHen.Location = new System.Drawing.Point(413, 3);
            this.btnLichHen.Name = "btnLichHen";
            this.btnLichHen.Size = new System.Drawing.Size(160, 94);
            this.btnLichHen.TabIndex = 0;
            this.btnLichHen.Text = "Lịch hẹn";
            this.btnLichHen.TextOffset = new System.Drawing.Point(-10, 20);
            this.btnLichHen.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBenhNhan.BorderColor = System.Drawing.Color.White;
            this.btnBenhNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBenhNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBenhNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBenhNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBenhNhan.FillColor = System.Drawing.Color.SteelBlue;
            this.btnBenhNhan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.btnBenhNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnBenhNhan.Image")));
            this.btnBenhNhan.ImageOffset = new System.Drawing.Point(25, -13);
            this.btnBenhNhan.ImageSize = new System.Drawing.Size(37, 37);
            this.btnBenhNhan.Location = new System.Drawing.Point(253, 3);
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.Size = new System.Drawing.Size(160, 94);
            this.btnBenhNhan.TabIndex = 0;
            this.btnBenhNhan.Text = "Bệnh Nhân";
            this.btnBenhNhan.TextOffset = new System.Drawing.Point(-9, 20);
            this.btnBenhNhan.Click += new System.EventHandler(this.btnBenhNhan_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNhanVien.BorderColor = System.Drawing.Color.White;
            this.btnNhanVien.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.FillColor = System.Drawing.Color.SteelBlue;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageOffset = new System.Drawing.Point(25, -13);
            this.btnNhanVien.ImageSize = new System.Drawing.Size(37, 37);
            this.btnNhanVien.Location = new System.Drawing.Point(96, 3);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(160, 94);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextOffset = new System.Drawing.Point(-6, 20);
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.SteelBlue;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1512, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "x";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBoxNen
            // 
            this.picBoxNen.Image = ((System.Drawing.Image)(resources.GetObject("picBoxNen.Image")));
            this.picBoxNen.ImageRotate = 0F;
            this.picBoxNen.Location = new System.Drawing.Point(0, -2);
            this.picBoxNen.Name = "picBoxNen";
            this.picBoxNen.Size = new System.Drawing.Size(1562, 816);
            this.picBoxNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxNen.TabIndex = 4;
            this.picBoxNen.TabStop = false;
            this.picBoxNen.Click += new System.EventHandler(this.picBoxNen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "DENTAL CLINIC NAME";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Shapes1.BorderThickness = 1;
            this.guna2Shapes1.FillColor = System.Drawing.Color.White;
            this.guna2Shapes1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Shapes1.LineThickness = 2;
            this.guna2Shapes1.Location = new System.Drawing.Point(3, 1006);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.RoundedRadius = 2;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(1562, 10);
            this.guna2Shapes1.TabIndex = 4;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Shapes2.BorderThickness = 1;
            this.guna2Shapes2.FillColor = System.Drawing.Color.White;
            this.guna2Shapes2.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Shapes2.LineThickness = 2;
            this.guna2Shapes2.Location = new System.Drawing.Point(3, 987);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.RoundedRadius = 2;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes2.Size = new System.Drawing.Size(1562, 10);
            this.guna2Shapes2.TabIndex = 4;
            this.guna2Shapes2.Text = "guna2Shapes1";
            this.guna2Shapes2.Zoom = 80;
            // 
            // guna2Shapes3
            // 
            this.guna2Shapes3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Shapes3.BorderThickness = 1;
            this.guna2Shapes3.FillColor = System.Drawing.Color.White;
            this.guna2Shapes3.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Shapes3.LineThickness = 2;
            this.guna2Shapes3.Location = new System.Drawing.Point(3, 966);
            this.guna2Shapes3.Name = "guna2Shapes3";
            this.guna2Shapes3.PolygonSkip = 1;
            this.guna2Shapes3.Rotate = 0F;
            this.guna2Shapes3.RoundedRadius = 2;
            this.guna2Shapes3.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes3.Size = new System.Drawing.Size(1562, 10);
            this.guna2Shapes3.TabIndex = 4;
            this.guna2Shapes3.Text = "guna2Shapes1";
            this.guna2Shapes3.Zoom = 80;
            // 
            // uC_LichHen1
            // 
            this.uC_LichHen1.Location = new System.Drawing.Point(-2, -2);
            this.uC_LichHen1.Name = "uC_LichHen1";
            this.uC_LichHen1.Size = new System.Drawing.Size(1564, 818);
            this.uC_LichHen1.TabIndex = 3;
            this.uC_LichHen1.Visible = false;
            // 
            // uC_BenhNhan1
            // 
            this.uC_BenhNhan1.BackColor = System.Drawing.Color.White;
            this.uC_BenhNhan1.Location = new System.Drawing.Point(-2, -2);
            this.uC_BenhNhan1.Name = "uC_BenhNhan1";
            this.uC_BenhNhan1.Size = new System.Drawing.Size(1564, 818);
            this.uC_BenhNhan1.TabIndex = 2;
            this.uC_BenhNhan1.Visible = false;
            // 
            // uC_NhanVien2
            // 
            this.uC_NhanVien2.BackColor = System.Drawing.Color.White;
            this.uC_NhanVien2.Location = new System.Drawing.Point(-2, -2);
            this.uC_NhanVien2.Name = "uC_NhanVien2";
            this.uC_NhanVien2.Size = new System.Drawing.Size(1559, 818);
            this.uC_NhanVien2.TabIndex = 1;
            this.uC_NhanVien2.Visible = false;
            // 
            // uC_NhanVien1
            // 
            this.uC_NhanVien1.Location = new System.Drawing.Point(79, 37);
            this.uC_NhanVien1.Name = "uC_NhanVien1";
            this.uC_NhanVien1.Size = new System.Drawing.Size(1858, 10);
            this.uC_NhanVien1.TabIndex = 0;
            this.uC_NhanVien1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1567, 1031);
            this.Controls.Add(this.guna2Shapes3);
            this.Controls.Add(this.guna2Shapes2);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnLichHen;
        private Guna.UI2.WinForms.Guna2Button btnBenhNhan;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private User_Control.UC_NhanVien uC_NhanVien1;
        private User_Control.UC_NhanVien uC_NhanVien2;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private User_Control.UC_BenhNhan uC_BenhNhan1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private User_Control.UC_LichHen uC_LichHen1;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxNen;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes3;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
    }
}