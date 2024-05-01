using QuanLyPhongKhamNhaKhoa.Dao;
using QuanLyPhongKhamNhaKhoa.Entity;
using QuanLyPhongKhamNhaKhoa.Validation;
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
    public partial class UC_DieuTri : UserControl
    {
        public UC_DieuTri()
        {
            InitializeComponent();
        }

        ServiceDao serviceDao = new ServiceDao();
        Service service = new Service();
        SQLConnectionData mydb = new SQLConnectionData();

        private void UC_DieuTri_Load(object sender, EventArgs e)
        {
            fillListBoxDSDichVu();
        }
        bool verifDichVu()
        {
            if ((txtTenDichVu.Text.Trim() == "")
                        || (txtChiPhiDichVu.Text.Trim() == "")
                        || (txtDonViDichVu.Text.Trim() == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // chỉ được nhập chữ
        private void txtTenDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //chỉ được nhập số
        private void txtChiPhiDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonViDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
        public void fillListBoxDSDichVu()
        {
            try
            {
                lbDSDichVu.Items.Clear();
                SqlCommand cmd = new SqlCommand("SELECT serviceID, serviceName FROM Service", mydb.getConnection);
                mydb.openConnection();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string serviceID = reader["serviceID"].ToString();
                        string name = reader["serviceName"].ToString();
                        lbDSDichVu.Items.Add(new KeyValuePair<string, string>(serviceID, name));
                    }
                }
                lbDSDichVu.DisplayMember = "Value";
                lbDSDichVu.ValueMember = "Key";
                mydb.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifDichVu())
                {
                    throw new InvalidData();
                }
                service.ServiceID = serviceDao.taoMaService();
                service.ServiceName = txtTenDichVu.Text.Trim();
                service.Unit = txtDonViDichVu.Text.Trim();
                service.Cost = float.Parse(txtChiPhiDichVu.Text.Trim());
                int soLuong = int.Parse(txtSoLuongDichVu.Text.Trim());

                if (serviceDao.insertService(service))
                {
                    MessageBox.Show("Thêm dịch vụ thành công!", "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new InvalidService("Thêm dịch vụ thất bại!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Add Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbDSDichVu_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbDSDichVu.SelectedItem != null)
                {
                    KeyValuePair<string, string> selectedService = (KeyValuePair<string, string>)lbDSDichVu.SelectedItem;
                    string serviceID = selectedService.Key;
                    SqlCommand command = new SqlCommand("SELECT * FROM Service WHERE serviceID=@serviceID");
                    command.Parameters.Add("@serviceID", SqlDbType.VarChar).Value = serviceID;
                    DataTable table = serviceDao.getSerivce(command);
                    if (table.Rows.Count > 0)
                    {
                        txtTenDichVu.Text = table.Rows[0]["serviceName"].ToString();
                        txtChiPhiDichVu.Text = table.Rows[0]["cost"].ToString();
                        txtDonViDichVu.Text = table.Rows[0]["unit"].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Exception Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
