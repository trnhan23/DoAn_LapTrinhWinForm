namespace QuanLyPhongKhamNhaKhoa.FormXuLyLichHen
{
    partial class FormThemLichHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemLichHen));
            this.dateTPKLichHen = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pBExit = new System.Windows.Forms.PictureBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblThemDichVu = new System.Windows.Forms.Label();
            this.pBThemDichVu = new System.Windows.Forms.PictureBox();
            this.pBSearchPatient = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenNhaSi = new System.Windows.Forms.Label();
            this.gBThongTinBenhNhan = new System.Windows.Forms.GroupBox();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.txtSDTBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.panelDichVu = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBThemDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSearchPatient)).BeginInit();
            this.gBThongTinBenhNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTPKLichHen
            // 
            resources.ApplyResources(this.dateTPKLichHen, "dateTPKLichHen");
            this.dateTPKLichHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPKLichHen.Name = "dateTPKLichHen";
            this.dateTPKLichHen.ValueChanged += new System.EventHandler(this.dateTPKLichHen_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pBExit);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Name = "label1";
            // 
            // pBExit
            // 
            this.pBExit.Image = global::QuanLyPhongKhamNhaKhoa.Properties.Resources.x;
            resources.ApplyResources(this.pBExit, "pBExit");
            this.pBExit.Name = "pBExit";
            this.pBExit.TabStop = false;
            this.pBExit.Click += new System.EventHandler(this.pBExit_Click);
            // 
            // txtCCCD
            // 
            resources.ApplyResources(this.txtCCCD, "txtCCCD");
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            this.txtCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCCD_KeyPress);
            // 
            // lblThemDichVu
            // 
            resources.ApplyResources(this.lblThemDichVu, "lblThemDichVu");
            this.lblThemDichVu.ForeColor = System.Drawing.Color.Gold;
            this.lblThemDichVu.Name = "lblThemDichVu";
            this.lblThemDichVu.Click += new System.EventHandler(this.lblThemDichVu_Click);
            // 
            // pBThemDichVu
            // 
            this.pBThemDichVu.BackColor = System.Drawing.Color.SteelBlue;
            this.pBThemDichVu.Image = global::QuanLyPhongKhamNhaKhoa.Properties.Resources.add;
            resources.ApplyResources(this.pBThemDichVu, "pBThemDichVu");
            this.pBThemDichVu.Name = "pBThemDichVu";
            this.pBThemDichVu.TabStop = false;
            this.pBThemDichVu.Click += new System.EventHandler(this.pBThemDichVu_Click);
            // 
            // pBSearchPatient
            // 
            this.pBSearchPatient.BackColor = System.Drawing.Color.White;
            this.pBSearchPatient.Image = global::QuanLyPhongKhamNhaKhoa.Properties.Resources.search;
            resources.ApplyResources(this.pBSearchPatient, "pBSearchPatient");
            this.pBSearchPatient.Name = "pBSearchPatient";
            this.pBSearchPatient.TabStop = false;
            this.pBSearchPatient.Click += new System.EventHandler(this.pBSearchPatient_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Name = "label3";
            // 
            // lblTenNhaSi
            // 
            resources.ApplyResources(this.lblTenNhaSi, "lblTenNhaSi");
            this.lblTenNhaSi.ForeColor = System.Drawing.Color.Gold;
            this.lblTenNhaSi.Name = "lblTenNhaSi";
            // 
            // gBThongTinBenhNhan
            // 
            this.gBThongTinBenhNhan.Controls.Add(this.btnThemBN);
            this.gBThongTinBenhNhan.Controls.Add(this.txtSDTBN);
            this.gBThongTinBenhNhan.Controls.Add(this.label7);
            this.gBThongTinBenhNhan.Controls.Add(this.label5);
            this.gBThongTinBenhNhan.Controls.Add(this.txtTenBN);
            resources.ApplyResources(this.gBThongTinBenhNhan, "gBThongTinBenhNhan");
            this.gBThongTinBenhNhan.ForeColor = System.Drawing.Color.Gold;
            this.gBThongTinBenhNhan.Name = "gBThongTinBenhNhan";
            this.gBThongTinBenhNhan.TabStop = false;
            // 
            // btnThemBN
            // 
            this.btnThemBN.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.btnThemBN, "btnThemBN");
            this.btnThemBN.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.UseVisualStyleBackColor = false;
            this.btnThemBN.Click += new System.EventHandler(this.btnThemBN_Click);
            // 
            // txtSDTBN
            // 
            resources.ApplyResources(this.txtSDTBN, "txtSDTBN");
            this.txtSDTBN.Name = "txtSDTBN";
            this.txtSDTBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTBN_KeyPress);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Name = "label5";
            // 
            // txtTenBN
            // 
            resources.ApplyResources(this.txtTenBN, "txtTenBN");
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenBN_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Name = "label4";
            // 
            // cbTime
            // 
            resources.ApplyResources(this.cbTime, "cbTime");
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Name = "cbTime";
            // 
            // panelDichVu
            // 
            resources.ApplyResources(this.panelDichVu, "panelDichVu");
            this.panelDichVu.Name = "panelDichVu";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ForeColor = System.Drawing.Color.Gold;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Gold;
            resources.ApplyResources(this.btnLuu, "btnLuu");
            this.btnLuu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Name = "label8";
            // 
            // FormThemLichHen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelDichVu);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gBThongTinBenhNhan);
            this.Controls.Add(this.lblTenNhaSi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThemDichVu);
            this.Controls.Add(this.pBThemDichVu);
            this.Controls.Add(this.pBSearchPatient);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTPKLichHen);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemLichHen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.FormThemLichHen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBThemDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSearchPatient)).EndInit();
            this.gBThongTinBenhNhan.ResumeLayout(false);
            this.gBThongTinBenhNhan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBExit;
        private System.Windows.Forms.DateTimePicker dateTPKLichHen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.PictureBox pBSearchPatient;
        private System.Windows.Forms.PictureBox pBThemDichVu;
        private System.Windows.Forms.Label lblThemDichVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenNhaSi;
        private System.Windows.Forms.GroupBox gBThongTinBenhNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Panel panelDichVu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.TextBox txtSDTBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemBN;
        private System.Windows.Forms.Label label8;
    }
}