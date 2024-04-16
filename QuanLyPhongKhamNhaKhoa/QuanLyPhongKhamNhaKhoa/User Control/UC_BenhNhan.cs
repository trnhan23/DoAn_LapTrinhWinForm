using QuanLyPhongKhamNhaKhoa.Dao;
using QuanLyPhongKhamNhaKhoa.Entity;
using QuanLyPhongKhamNhaKhoa.Validation;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyPhongKhamNhaKhoa.User_Control
{
    public partial class UC_BenhNhan : UserControl
    {
        public UC_BenhNhan()
        {
            InitializeComponent();
        }
        PatientsDao patientsDao = new PatientsDao();
        public void refesh()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Patients");
            fillGrid(command);
            reset();
        }
        public void reset()
        {
            txtMaBN.Text = "";
            txtHoTen.Text = "";
            txtCCCD.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTimKiem.Text = "";
            rbMale.Checked = true;
            picBoxImage.Image = null;
            dateTimePickerNgSinh.Value = DateTime.Now;
        }
        bool verif()
        {
            if ((txtHoTen.Text.Trim() == "")
                        || (dateTimePickerNgSinh.Text.Trim() == "")
                        || (txtCCCD.Text.Trim() == "")
                        || (txtSDT.Text.Trim() == "")
                        || (picBoxImage.Image == null)
                        || (txtDiaChi.Text.Trim() == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void fillGrid(SqlCommand command)
        {
            try
            {
                dataPatient.ReadOnly = true;
                dataPatient.DataSource = patientsDao.getPatients(command);
                dataPatient.AllowUserToAddRows = false;
                dataPatient.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                dataPatient.RowTemplate.Height = 80;
                picCol = (DataGridViewImageColumn)dataPatient.Columns["image"];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                // đổi tên cột
                dataPatient.Columns["patientsID"].HeaderText = "Mã bệnh nhân";
                dataPatient.Columns["fullName"].HeaderText = "Họ và tên";
                dataPatient.Columns["birthDate"].HeaderText = "Ngày sinh";
                dataPatient.Columns["gender"].HeaderText = "Giới tính";
                dataPatient.Columns["persionalID"].HeaderText = "CCCD";
                dataPatient.Columns["phoneNumber"].HeaderText = "Số điện thoại";
                dataPatient.Columns["address"].HeaderText = "Địa chỉ";
                dataPatient.Columns["image"].HeaderText = "Ảnh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset();
            refesh();
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    throw new InvalidData();
                }
                string patientId = txtMaBN.Text.Trim();
                if (patientsDao.existPatients(patientId))
                {
                    throw new InvalidExistPatients();
                }
                string fullName = txtHoTen.Text.Trim();
                string persionalID = txtCCCD.Text.Trim();
                string phone = txtSDT.Text.Trim();

                string address = txtDiaChi.Text.Trim();
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
                int born_year = dateTimePickerNgSinh.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 3))
                {
                    throw new InvalidBirthdate(3);
                }
                DateTime birthDate = dateTimePickerNgSinh.Value;

                string gender = "Nam";
                if (rbFemale.Checked)
                {
                    gender = "Nữ";
                }

                MemoryStream pic = new MemoryStream();
                picBoxImage.Image.Save(pic, picBoxImage.Image.RawFormat);
                //tạo mã user tự động
                string patientsID = patientsDao.taoMaPatients();

                Patients patients = new Patients(patientsID, fullName, gender, birthDate, persionalID, phone, address, pic);
                if (patientsDao.insertPatients(patients))
                {
                    MessageBox.Show("Thêm bệnh nhân thành công!", "Add Patients", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refesh();
                    reset();
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

        private void btnSuaBN_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    throw new InvalidData();
                }
                string patientsID = txtMaBN.Text.Trim();
                if (!patientsDao.existPatients(patientsID))
                {
                    throw new InvalidExistPatients("Không tồn tại bệnh nhân có mã nhân viên này!");
                }
                string fullName = txtHoTen.Text.Trim();
                string persionalID = txtCCCD.Text.Trim();
                string phone = txtSDT.Text.Trim();
                string address = txtDiaChi.Text.Trim();

                SqlCommand command = new SqlCommand("SELECT persionalID FROM Patients WHERE patientsID=@patientsID");
                command.Parameters.Add("@patientsID", SqlDbType.VarChar).Value = patientsID;
                DataTable table = patientsDao.getPatients(command);
                string check_persionalID = "";
                if (table.Rows.Count > 0)
                {
                    check_persionalID = table.Rows[0]["persionalID"].ToString().Trim();
                }

                if (!Regex.IsMatch(fullName, @"^[\p{L}\s]+$"))
                {
                    throw new InvalidName();
                }
                if (!Regex.IsMatch(persionalID, @"^\d{12}$"))
                {
                    throw new InvalidPersionalID();
                }
                if (!check_persionalID.Equals(persionalID))
                {
                    if (patientsDao.existPersionalIDPatients(persionalID))
                    {
                        throw new InvalidPersionalID(persionalID);
                    }
                }
                if (!Regex.IsMatch(phone, @"^0\d{9}$"))
                {
                    throw new InvalidSDT();
                }

                int born_year = dateTimePickerNgSinh.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 3))
                {
                    throw new InvalidBirthdate(3);
                }
                DateTime birthDate = dateTimePickerNgSinh.Value;

                string gender = "Nam";
                if (rbFemale.Checked)
                {
                    gender = "Nữ";
                }

                MemoryStream pic = new MemoryStream();
                picBoxImage.Image.Save(pic, picBoxImage.Image.RawFormat);

                Patients patients = new Patients(patientsID, fullName, gender, birthDate, persionalID, phone, address, pic);
                if (patientsDao.updatePatients(patients))
                {
                    MessageBox.Show("Cập nhật thông tin bệnh nhân thành công!", "Update Patients", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refesh();
                    reset();
                }
                else
                {
                    throw new InvalidExistPatients("Cập nhật thông tin bệnh nhân thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Update Patients", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaBN_Click(object sender, EventArgs e)
        {
            try
            {
                string patientsID = txtMaBN.Text.Trim();
                if (!patientsDao.existPatients(patientsID))
                {
                    throw new InvalidExistUsers("Bạn chưa chọn bệnh nhân cần xoá!");
                }

                //coi chừng khoá ngoại
                if (MessageBox.Show("Bạn có chắc chắn muốn xoá bệnh nhân không?", "Delete Patient", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (patientsDao.deletePatients(patientsID))
                    {
                        MessageBox.Show("Xoá bệnh nhân thành công!", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refesh();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Xoá bệnh nhân thất bại!", "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Delete Patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timKiem();
        }
        public void timKiem()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Patients WHERE patientsID LIKE @timKiem OR fullName LIKE @timKiem OR persionalID LIKE @timKiem OR " +
                "phoneNumber LIKE @timKiem ");
            command.Parameters.Add("@timKiem", SqlDbType.NVarChar).Value = "%" + txtTimKiem.Text.Trim() + "%";
            fillGrid(command);
        }
        private void btnXuatDuLieu_Click(object sender, EventArgs e)
        {

        }

        private void UC_BenhNhan_Load(object sender, EventArgs e)
        {
            refesh();
        }

        private void dataPatient_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaBN.Text = dataPatient.CurrentRow.Cells["patientsID"].Value.ToString();
                txtHoTen.Text = dataPatient.CurrentRow.Cells["fullName"].Value.ToString();
                dateTimePickerNgSinh.Value = (DateTime)dataPatient.CurrentRow.Cells["birthDate"].Value;
                if (dataPatient.CurrentRow.Cells["gender"].Value.ToString().Trim() == "Nữ")
                {
                    rbFemale.Checked = true;
                }
                else rbMale.Checked = true;

                txtCCCD.Text = dataPatient.CurrentRow.Cells["persionalID"].Value.ToString();
                txtSDT.Text = dataPatient.CurrentRow.Cells["phoneNumber"].Value.ToString();
                txtDiaChi.Text = dataPatient.CurrentRow.Cells["address"].Value.ToString();

                //xử lý ảnh
                byte[] pic;
                if (dataPatient.CurrentRow.Cells["image"].Value == null || string.IsNullOrEmpty(dataPatient.CurrentRow.Cells["image"].Value.ToString()))
                {
                    picBoxImage.Image = Image.FromFile(@"..\..\image\logo.png");
                }
                else
                {
                    pic = (byte[])dataPatient.CurrentRow.Cells["image"].Value;
                    MemoryStream picture = new MemoryStream(pic);
                    picBoxImage.Image = Image.FromStream(picture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }
    }
}
