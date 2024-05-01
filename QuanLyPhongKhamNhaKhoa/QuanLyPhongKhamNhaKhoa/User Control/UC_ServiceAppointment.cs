using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKhamNhaKhoa.User_Control
{
    public partial class UC_ServiceAppointment : UserControl
    {
        public string tenDichVu { get; set; }
        public string giaTien { get; set; }
        public string unit { get; set; }
        public UC_ServiceAppointment()
        {
            InitializeComponent();
        }
        private void UC_ServiceAppointment_Load(object sender, EventArgs e)
        {
            lblTenDichVu.Text = tenDichVu;
            lblGiaTien.Text = giaTien + "/" + unit;
        }
    }
}
