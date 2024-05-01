namespace QuanLyPhongKhamNhaKhoa.FormXuLyLichHen
{
    partial class FormChonDichVu
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
            this.pBExit = new System.Windows.Forms.PictureBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelDichVu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBSearchPatient = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSearchPatient)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBExit
            // 
            this.pBExit.Image = global::QuanLyPhongKhamNhaKhoa.Properties.Resources.x;
            this.pBExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pBExit.Location = new System.Drawing.Point(728, 7);
            this.pBExit.Name = "pBExit";
            this.pBExit.Size = new System.Drawing.Size(20, 20);
            this.pBExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBExit.TabIndex = 0;
            this.pBExit.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Gold;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnLuu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLuu.Location = new System.Drawing.Point(597, 528);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(136, 45);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnCancel.ForeColor = System.Drawing.Color.Gold;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(443, 528);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 45);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // panelDichVu
            // 
            this.panelDichVu.Location = new System.Drawing.Point(13, 94);
            this.panelDichVu.Name = "panelDichVu";
            this.panelDichVu.Size = new System.Drawing.Size(731, 428);
            this.panelDichVu.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(323, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tìm theo tên, mã dịch vụ";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCCCD.Location = new System.Drawing.Point(11, 58);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(306, 30);
            this.txtCCCD.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn dịch vụ";
            // 
            // pBSearchPatient
            // 
            this.pBSearchPatient.BackColor = System.Drawing.Color.White;
            this.pBSearchPatient.Image = global::QuanLyPhongKhamNhaKhoa.Properties.Resources.search;
            this.pBSearchPatient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pBSearchPatient.Location = new System.Drawing.Point(287, 61);
            this.pBSearchPatient.Name = "pBSearchPatient";
            this.pBSearchPatient.Size = new System.Drawing.Size(27, 27);
            this.pBSearchPatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSearchPatient.TabIndex = 22;
            this.pBSearchPatient.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pBExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 49);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::QuanLyPhongKhamNhaKhoa.Properties.Resources.search;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(290, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // FormChonDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(756, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelDichVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.pBSearchPatient);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChonDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChonDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.pBExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSearchPatient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBExit;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelDichVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBSearchPatient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}