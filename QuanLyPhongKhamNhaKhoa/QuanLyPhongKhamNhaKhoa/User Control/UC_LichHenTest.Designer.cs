namespace QuanLyPhongKhamNhaKhoa.User_Control
{
    partial class UC_LichHenTest
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
            this.btnDatLich = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.cBoxNotify = new System.Windows.Forms.CheckBox();
            this.panelDate = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDatLich
            // 
            this.btnDatLich.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDatLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLich.ForeColor = System.Drawing.Color.White;
            this.btnDatLich.Location = new System.Drawing.Point(1399, 16);
            this.btnDatLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(149, 38);
            this.btnDatLich.TabIndex = 64;
            this.btnDatLich.Text = "Đặt lịch ";
            this.btnDatLich.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch hẹn";
            // 
            // dtpkDate
            // 
            this.dtpkDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpkDate.Location = new System.Drawing.Point(1164, 20);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(163, 30);
            this.dtpkDate.TabIndex = 66;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // cBoxNotify
            // 
            this.cBoxNotify.AutoSize = true;
            this.cBoxNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxNotify.Location = new System.Drawing.Point(178, 25);
            this.cBoxNotify.Name = "cBoxNotify";
            this.cBoxNotify.Size = new System.Drawing.Size(74, 24);
            this.cBoxNotify.TabIndex = 67;
            this.cBoxNotify.Text = "Notify";
            this.cBoxNotify.UseVisualStyleBackColor = true;
            // 
            // panelDate
            // 
            this.panelDate.Location = new System.Drawing.Point(18, 59);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(1530, 740);
            this.panelDate.TabIndex = 68;
            // 
            // UC_LichHenTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDate);
            this.Controls.Add(this.cBoxNotify);
            this.Controls.Add(this.dtpkDate);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.label1);
            this.Name = "UC_LichHenTest";
            this.Size = new System.Drawing.Size(1564, 818);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.CheckBox cBoxNotify;
        private System.Windows.Forms.Panel panelDate;
    }
}
