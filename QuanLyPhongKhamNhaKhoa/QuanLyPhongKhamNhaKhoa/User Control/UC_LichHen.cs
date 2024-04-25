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

namespace QuanLyPhongKhamNhaKhoa.User_Control
{
    public partial class UC_LichHen : UserControl
    {

        PatientsDao patientsDao = new PatientsDao();
        UserDao usersDao = new UserDao();
        AppointmentDao appDao = new AppointmentDao();
        public UC_LichHen()
        {
            InitializeComponent();
        }
        private void UC_LichHen_Load(object sender, EventArgs e)
        {
            load();
            comboBoxTrangThai.Items.Add("Đặt lịch");
            comboBoxTrangThai.Items.Add("Huỷ lịch");
            comboBoxTrangThai.SelectedItem = "Đặt lịch";
            comboBoxTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT patientsID, fullName, birthDate, gender, phoneNumber, address " +
                "FROM Patients WHERE persionalID LIKE @persionalID");
            command.Parameters.Add("@persionalID", SqlDbType.VarChar).Value = "%" + txtCCCDBN.Text.Trim() + "%";

            DataTable table = patientsDao.getPatients(command);
            if (table.Rows.Count > 0)
            {
                txtMaBN.Text = table.Rows[0]["patientsID"].ToString().Trim();
                txtTenBN.Text = table.Rows[0]["fullName"].ToString().Trim();
                dateTimePickerNgaySinh.Value = (DateTime)table.Rows[0]["birthDate"];
                radioButtonFemale.Checked = true;
                if (table.Rows[0]["gender"].ToString().Trim().Equals("Nam"))
                {
                    radioButtonMale.Checked = true;
                }
                txtSoDTBN.Text = table.Rows[0]["phoneNumber"].ToString().Trim();
                txtDiaChiBN.Text = table.Rows[0]["address"].ToString().Trim();
            }
            else
            {
                txtMaBN.Text = "";
                dateTimePickerNgaySinh.Value = DateTime.Now;
                radioButtonMale.Checked = true;
                txtTenBN.Text = "";
                txtSoDTBN.Text = "";
                txtDiaChiBN.Text = "";
            }
        }
        public void load()
        {
            try
            {
                DataTable table = usersDao.getAllDentist();
                if (table.Rows.Count > 0)
                {
                    //gán cho combobox bác sĩ
                    table.Columns.Add("FullNameWithID", typeof(string), "userID + ' - ' + fullName");
                    comboBoxBacSi.DisplayMember = "FullNameWithID";
                    comboBoxBacSi.DataSource = table;

                    //gán giá trị cho gridview
                    hienThiGridView();
                    hienThiThongTinBacSi();
                }
                else
                {
                    comboBoxBacSi.Items.Add("Không tìm thấy");
                    comboBoxBacSi.SelectedIndex = 0;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void hienThiThongTinLichHen(string maLichHen)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Appointment WHERE appointmentID=@appointmentID");
                command.Parameters.Add("@appointmentID", SqlDbType.VarChar).Value = maLichHen.Trim();
                DataTable table = appDao.getAppointment(command);
                if (table.Rows.Count > 0)
                {
                    txtMaLichHen.Text = table.Rows[0]["appointmentID"].ToString().Trim();
                    dateTimePickerNgayHen.Value = (DateTime)table.Rows[0]["appointmentDate"];

                    TimeSpan startTime = (TimeSpan)table.Rows[0]["startTime"];
                    TimeSpan endTime = (TimeSpan)table.Rows[0]["endTime"];

                    pickTimeStart.Value = DateTime.Today.Add(startTime);
                    pickTimeEnd.Value = DateTime.Today.Add(endTime);

                    comboBoxTrangThai.Text = table.Rows[0]["status"].ToString().Trim();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void hienThiThongTinBenhNhan(string CCCD)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Patients WHERE persionalID=@persionalID");
                command.Parameters.Add("@persionalID", SqlDbType.VarChar).Value = CCCD.Trim();
                DataTable table = appDao.getAppointment(command);
                if (table.Rows.Count > 0)
                {
                    txtCCCDBN.Text = table.Rows[0]["persionalID"].ToString().Trim();
                    txtTenBN.Text = table.Rows[0]["fullName"].ToString().Trim();
                    dateTimePickerNgaySinh.Value = (DateTime)table.Rows[0]["birthDate"];
                    radioButtonFemale.Checked = true;
                    if(table.Rows[0]["gender"].ToString().Trim().Equals("Nam"))
                        radioButtonMale.Checked = true;
                    txtSoDTBN.Text = table.Rows[0]["phoneNumber"].ToString().Trim();
                    txtDiaChiBN.Text = table.Rows[0]["address"].ToString().Trim();
                    txtMaBN.Text = table.Rows[0]["patientsID"].ToString().Trim();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataLichHen_Click(object sender, EventArgs e)
        {
            string maLichHen = dataLichHen.CurrentRow.Cells["appointmentID"].Value.ToString();
            hienThiThongTinLichHen(maLichHen);
            string cccd = dataLichHen.CurrentRow.Cells["persionalID"].Value.ToString();
            hienThiThongTinBenhNhan(cccd);
        }
        public void hienThiThongTinBacSi()
        {
            string[] parts = comboBoxBacSi.Text.Split(new[] { " - " }, StringSplitOptions.None);
            string userID = parts[0];
            string fullName = parts[1];

            SqlCommand command = new SqlCommand("SELECT phoneNumber, email FROM Users WHERE userID=@userID");
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = userID;
            DataTable table = usersDao.getUsers(command);
            if (table.Rows.Count > 0)
            {
                txtMaBS.Text = userID.Trim();
                txtTenBS.Text = fullName.Trim();
                txtSoDTBS.Text = table.Rows[0]["phoneNumber"].ToString().Trim();
                txtEmailBS.Text = table.Rows[0]["email"].ToString().Trim();
            }
        }
        public void hienThiGridView()
        {
            try
            {
                string[] parts = comboBoxBacSi.Text.Split(new[] { " - " }, StringSplitOptions.None);
                string userId = parts[0];
                string fullName = parts[1];

                string fullNameBS = comboBoxBacSi.Text.Trim();
                SqlCommand command = new SqlCommand("SELECT a.appointmentID, u.fullName, p.fullName, p.persionalID, a.appointmentDate, a.startTime, a.endTime, a.status\r\n" +
                    "FROM (Appointment a LEFT JOIN Users u ON a.userID = u.userID) LEFT JOIN Patients p ON a.patientsID = p.patientsID\r\n" +
                    "WHERE u.userID = a.userID AND u.userID=@userID AND u.isRole='DENTIST'");
                command.Parameters.Add("@userID", SqlDbType.VarChar).Value = userId;
                fillGrid(command);
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fillGrid(SqlCommand command)
        {
            try
            {
                dataLichHen.ReadOnly = true;
                dataLichHen.DataSource = usersDao.getUsers(command);
                dataLichHen.AllowUserToAddRows = false;
                dataLichHen.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // đổi tên cột
                dataLichHen.Columns["appointmentID"].HeaderText = "Mã cuộc hẹn";
                dataLichHen.Columns[1].HeaderText = "Tên nha sĩ";
                dataLichHen.Columns[2].HeaderText = "Tên bệnh nhân";
                dataLichHen.Columns["persionalID"].HeaderText = "CCCD bệnh nhân";
                dataLichHen.Columns["appointmentDate"].HeaderText = "Ngày hẹn";
                dataLichHen.Columns["startTime"].HeaderText = "Thời gian bắt đầu";
                dataLichHen.Columns["endTime"].HeaderText = "Thời gian kết thúc";
                dataLichHen.Columns["status"].HeaderText = "Trạng thái";


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string patientId = txtMaBN.Text.Trim();
                if (patientsDao.existPatients(patientId))
                {
                    throw new InvalidExistPatients();
                }
                string fullName = txtTenBN.Text.Trim();
                string persionalID = txtCCCDBN.Text.Trim();
                string phone = txtSoDTBN.Text.Trim();

                string address = txtDiaChiBN.Text.Trim();
                if (!Regex.IsMatch(fullName, @"^[\p{L}\s]+$"))
                {
                    throw new InvalidName();
                }
                if (!Regex.IsMatch(persionalID, @"^\d{12}$"))
                {
                    throw new InvalidPersionalID();
                }
                if (patientsDao.existPersionalIDPatients(persionalID))
                {
                    throw new InvalidPersionalID(persionalID);
                }
                if (!Regex.IsMatch(phone, @"^0\d{9}$"))
                {
                    throw new InvalidSDT();
                }
                int born_year = dateTimePickerNgaySinh.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 3))
                {
                    throw new InvalidBirthdate(3);
                }
                DateTime birthDate = dateTimePickerNgaySinh.Value;

                string gender = "Nam";
                if (radioButtonFemale.Checked)
                {
                    gender = "Nữ";
                }

                //do bên đặt lịch hẹn ko có ảnh người dùng nên gắn ảnh tạm
                MemoryStream pic = new MemoryStream();
                Image image = Image.FromFile(@"..\..\image\user.jpg");
                image.Save(pic, image.RawFormat);

                //tạo mã user tự động
                string patientsID = patientsDao.taoMaPatients();

                Patients patients = new Patients(patientsID, fullName, gender, birthDate, persionalID, phone, address, pic);
                if (patientsDao.insertPatients(patients))
                {
                    MessageBox.Show("Thêm bệnh nhân thành công!", "Add Patients", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new InvalidExistPatients("Thêm bệnh nhân thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Add Patients", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void capNhatMaBenhNhan(string patientsID)
        {
            SqlCommand command = new SqlCommand("SELECT patientsID FROM Patients WHERE persionalID=@persionalID");
            command.Parameters.Add("@persionalID", SqlDbType.VarChar).Value = txtCCCDBN.Text.Trim();
            DataTable table = patientsDao.getPatients(command);
            if (table.Rows.Count > 0)
            {
                patientsID = table.Rows[0]["patientsID"].ToString().Trim();
                txtMaBN.Text = patientsID;
            }
        }
        bool verifAppointment()
        {
            if ((dateTimePickerNgayHen.Text.Trim() == "")
                        || (pickTimeStart.Text == "")
                        || (pickTimeEnd.Text == "")
                        || (comboBoxTrangThai.Text.Trim() == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool verifBenhNhan()
        {
            if ((txtTenBN.Text.Trim() == "")
                        || (dateTimePickerNgaySinh.Text.Trim() == "")
                        || (txtCCCDBN.Text.Trim() == "")
                        || (txtSoDTBN.Text.Trim() == "")
                        || (txtDiaChiBN.Text.Trim() == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void comboBoxBacSi_SelectedValueChanged(object sender, EventArgs e)
        {
            hienThiGridView();
            hienThiThongTinBacSi();
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            try
            {
                string patientsID = txtMaBN.Text.Trim();
                //thêm bệnh nhân nếu chưa được đăng kí
                // mốt có xác nhận bằng khuôn mặt
                if (!patientsDao.existPatients(patientsID))
                {
                    themBenhNhan();
                    //sau khi thêm xong thì cập nhật lại mã bệnh nhân lên text
                    capNhatMaBenhNhan(patientsID);
                }

                if (verifAppointment())
                {
                    throw new InvalidData();
                }

                string appointmentID = appDao.taoMaAppointment();
                if (appDao.existAppointment(appointmentID))
                    throw new InvalidExistAppointment();

                string userID = txtMaBS.Text.Trim();

                DateTime ngayHen = dateTimePickerNgayHen.Value;
                string trangThai = comboBoxTrangThai.Text.Trim();

                DateTime timeStart = pickTimeStart.Value;
                DateTime timeEnd = pickTimeEnd.Value;
                
                string timestart = timeStart.ToString("HH:mm:ss").Trim();
                string timeend = timeEnd.ToString("HH:mm:ss").Trim();
                //Kiểm tra thời gian bị trùng
                if (appDao.kiemTraThoiGian(timestart, timeend, userID))
                {
                    throw new InvalidExistAppointment("Thời gian hẹn đã bị trùng với người khác!\nVui lòng chọn khoảng thời gian khác!");
                }

                if (appDao.insertAppointment(appointmentID, patientsID, userID, ngayHen, timestart, timeend, trangThai))
                {
                    MessageBox.Show("Thêm cuộc hẹn thành công!", "Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThiGridView();
                }
                else
                {
                    throw new InvalidExistAppointment("Thêm cuộc hẹn thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaLichHen.Text = "";
            dateTimePickerNgayHen.Value = DateTime.Now;
            pickTimeStart.Value = DateTime.Now;
            pickTimeEnd.Value = DateTime.Now;
            comboBoxTrangThai.Text = "Đặt lịch";
        }

        private void comboBoxBacSi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
