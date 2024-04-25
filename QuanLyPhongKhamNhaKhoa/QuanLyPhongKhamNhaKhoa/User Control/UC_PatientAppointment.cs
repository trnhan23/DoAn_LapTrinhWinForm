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
    public partial class UC_PatientAppointment : UserControl
    {
        public UC_PatientAppointment()
        {
            InitializeComponent();
        }
        public string TextFullName { get; set; }
        public string TextTime { get; set; }
        public string Status { get; set; }

        public string AppointmentID { get; set; }

        private void UC_PatientAppointment_Load(object sender, EventArgs e)
        {
            label1.Text = TextFullName;
            label2.Text = TextTime;
            loadColor();
            //picDelete.Click += picDelete_Click;
        }

        private void loadColor()
        {
            if (Status == "BOOKED")
            {
                this.BackColor = Color.LightGray;
            }
            else
            {
                this.BackColor = Color.FromArgb(0, 245, 255);
            }
        }
        public event EventHandler PicDelete_Click;

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (PicDelete_Click != null)
            {
                PicDelete_Click(this, EventArgs.Empty);
            }
        }
    }
}
