using QuanLyPhongKhamNhaKhoa.Dao;
using QuanLyPhongKhamNhaKhoa.Entity;
using QuanLyPhongKhamNhaKhoa.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKhamNhaKhoa.FormXuLyLichHen
{
    public partial class FormThemLichHen : Form
    {
        public FormThemLichHen()
        {
            InitializeComponent();
        }
        SQLConnectionData mydb = new SQLConnectionData();
        PatientsDao patientsDao = new PatientsDao();
        AppointmentDao appDao = new AppointmentDao();
        public string fullNameNS;
        public string userIDNS;
        string patientsID;
        private void pBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormThemLichHen_Load(object sender, EventArgs e)
        {
            lblTenNhaSi.Text = fullNameNS;
            taoThoiGianChoCbTime();
            cbTime.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void taoThoiGianChoCbTime()
        {
            cbTime.Items.Clear();
            string dateString = dateTPKLichHen.Value.ToString("dd/MM/yyyy");
            DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            List<int> hourTimeList = new List<int>();
            SqlCommand command = new SqlCommand(@"SELECT startTime FROM Appointment WHERE userID=@userID AND appointmentDate=@appointmentDate");
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = userIDNS.Trim();
            command.Parameters.Add("@appointmentDate", SqlDbType.DateTime).Value = date;

            DataTable table = appDao.getAppointment(command);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    TimeSpan startTime = (TimeSpan)row["startTime"];
                    int hour = startTime.Hours;
                    hourTimeList.Add(hour);
                }
            }

            for (int i = 8; i < 17; i++)
            {
                if (!hourTimeList.Contains(i) && i != 12)
                {
                    string temp = i.ToString() + "h - " + (i + 1).ToString() + "h";
                    cbTime.Items.Add(temp);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT fullName, phoneNumber, patientsID " +
                "FROM Patients WHERE persionalID LIKE @persionalID");
            command.Parameters.Add("@persionalID", SqlDbType.VarChar).Value = "%" + txtCCCD.Text.Trim() + "%";

            DataTable table = patientsDao.getPatients(command);
            if (table.Rows.Count > 0)
            {
                txtTenBN.Text = table.Rows[0]["fullName"].ToString().Trim();
                txtSDTBN.Text = table.Rows[0]["phoneNumber"].ToString().Trim();
                patientsID = table.Rows[0]["patientsID"].ToString().Trim();
            }
            else
            {
                txtTenBN.Text = "";
                txtSDTBN.Text = "";
            }
        }
        
        public void themBenhNhan()
        {
            try
            {
                if (verifBenhNhan())
                {
                    throw new InvalidData();
                }
                string fullName = txtTenBN.Text.Trim();
                string persionalID = txtCCCD.Text.Trim();
                string phone = txtSDTBN.Text.Trim();
                //kiểm tra cccd đã tồn tại hay chưa
                if (patientsDao.existPersionalIDPatients(persionalID))
                {
                    throw new InvalidPersionalID(persionalID);
                }
                //do bên đặt lịch hẹn ko có ảnh người dùng nên gắn ảnh tạm
                MemoryStream pic = new MemoryStream();
                Image image = Image.FromFile(@"..\..\image\user.jpg");
                image.Save(pic, image.RawFormat);

                //tạo mã user tự động
                patientsID = patientsDao.taoMaPatients();

                SqlCommand command = new SqlCommand("INSERT INTO Patients (patientsID, fullName, birthDate, persionalID, phoneNumber, image)" +
                " VALUES (@id, @fn, @bdt, @perID, @phn, @image)", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = patientsID.Trim();
                command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fullName.Trim();
                command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = DateTime.Now;
                command.Parameters.Add("@perID", SqlDbType.VarChar).Value = persionalID.Trim();
                command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone.Trim();
                command.Parameters.Add("@image", SqlDbType.Image).Value = pic.ToArray();

                mydb.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    mydb.closeConnection();
                    MessageBox.Show("Thêm bệnh nhân thành công!", "Add Patients", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    mydb.closeConnection();
                    throw new InvalidExistPatients("Thêm bệnh nhân thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Add Patients", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        bool verifBenhNhan()
        {
            if ((txtTenBN.Text.Trim() == "")
                        || (txtCCCD.Text.Trim() == "")
                        || (txtSDTBN.Text.Trim() == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void txtTenBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCCCD.Text.Length >= 12 && e.KeyChar != (char)Keys.Back || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDTBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSDTBN.Text.Length >= 10 && e.KeyChar != (char)Keys.Back ||
            (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || (txtSDTBN.Text.Length == 0 && e.KeyChar != '0'))))
            {
                e.Handled = true;
            }
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            themBenhNhan();
        }

        private void pBSearchPatient_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT persionalID " +
                "FROM Patients WHERE persionalID LIKE @persionalID AND patientsID=@patientsID");
            command.Parameters.Add("@persionalID", SqlDbType.VarChar).Value = "%" + txtCCCD.Text.Trim() + "%";
            command.Parameters.Add("@patientsID", SqlDbType.VarChar).Value = patientsID.Trim();
            DataTable table = patientsDao.getPatients(command);
            if (table.Rows.Count > 0)
            {
                txtCCCD.Text = table.Rows[0]["persionalID"].ToString().Trim();
            }
        }

        private void dateTPKLichHen_ValueChanged(object sender, EventArgs e)
        {
            taoThoiGianChoCbTime();
        }
    }
}
