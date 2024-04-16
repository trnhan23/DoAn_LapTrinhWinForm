namespace QuanLyPhongKhamNhaKhoa.User_Control
{
    partial class UC_TuyChonTaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUserName = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.lblXemHoSo = new System.Windows.Forms.Label();
            this.lblDoiMatKhau = new System.Windows.Forms.Label();
            this.lblDangXuat = new System.Windows.Forms.Label();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(15, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(137, 29);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Shapes1.LineThickness = 1;
            this.guna2Shapes1.Location = new System.Drawing.Point(-16, 44);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(370, 14);
            this.guna2Shapes1.TabIndex = 1;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // lblXemHoSo
            // 
            this.lblXemHoSo.AutoSize = true;
            this.lblXemHoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemHoSo.Location = new System.Drawing.Point(16, 79);
            this.lblXemHoSo.Name = "lblXemHoSo";
            this.lblXemHoSo.Size = new System.Drawing.Size(118, 20);
            this.lblXemHoSo.TabIndex = 2;
            this.lblXemHoSo.Text = "Hồ sơ của bạn";
            this.lblXemHoSo.Click += new System.EventHandler(this.lblXemHoSo_Click);
            // 
            // lblDoiMatKhau
            // 
            this.lblDoiMatKhau.AutoSize = true;
            this.lblDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMatKhau.Location = new System.Drawing.Point(16, 122);
            this.lblDoiMatKhau.Name = "lblDoiMatKhau";
            this.lblDoiMatKhau.Size = new System.Drawing.Size(107, 20);
            this.lblDoiMatKhau.TabIndex = 2;
            this.lblDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.AutoSize = true;
            this.lblDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangXuat.Location = new System.Drawing.Point(16, 183);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(106, 20);
            this.lblDangXuat.TabIndex = 2;
            this.lblDangXuat.Text = "ĐĂNG XUẤT";
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Shapes2.LineThickness = 1;
            this.guna2Shapes2.Location = new System.Drawing.Point(-16, 160);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes2.Size = new System.Drawing.Size(370, 14);
            this.guna2Shapes2.TabIndex = 1;
            this.guna2Shapes2.Text = "guna2Shapes1";
            this.guna2Shapes2.Zoom = 80;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_TuyChonTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDangXuat);
            this.Controls.Add(this.lblDoiMatKhau);
            this.Controls.Add(this.lblXemHoSo);
            this.Controls.Add(this.guna2Shapes2);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.lblUserName);
            this.Name = "UC_TuyChonTaiKhoan";
            this.Size = new System.Drawing.Size(341, 221);
            this.Load += new System.EventHandler(this.UC_TuyChonTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.Label lblXemHoSo;
        private System.Windows.Forms.Label lblDangXuat;
        private System.Windows.Forms.Label lblDoiMatKhau;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public System.Windows.Forms.Label lblUserName;
    }
}
