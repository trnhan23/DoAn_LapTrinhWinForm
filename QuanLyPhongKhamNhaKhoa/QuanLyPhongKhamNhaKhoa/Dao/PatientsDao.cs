using QuanLyPhongKhamNhaKhoa.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.IO;

namespace QuanLyPhongKhamNhaKhoa.Dao
{
    class PatientsDao
    {
        SQLConnectionData mydb = new SQLConnectionData();
        private Random random = new Random();
        public string taoMaPatients()
        {
            const string chars = "0123456789";
            string result;
            do
            {
                string randomPart = new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
                result = $"PATI{randomPart}";

            } while (existPatients(result));
            return result;
        }
        public bool existPersionalIDPatients(string persionalID)
        {
            try
            {
                mydb.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Patients WHERE persionalID = @persionalID", mydb.getConnection);
                command.Parameters.Add("@persionalID", SqlDbType.VarChar).Value = persionalID;
                var result = command.ExecuteReader();
                if (result.HasRows)
                {
                    mydb.closeConnection();
                    return true;
                }
                mydb.closeConnection();
                return false;
            }
            catch
            {
                return true;
            }
        }
        public bool existPatients(string id)
        {
            try
            {
                mydb.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Patients WHERE patientsID = @patientsID", mydb.getConnection);
                command.Parameters.Add("@patientsID", SqlDbType.VarChar).Value = id;
                var result = command.ExecuteReader();
                if (result.HasRows)
                {
                    mydb.closeConnection();
                    return true;
                }
                mydb.closeConnection();
                return false;
            }
            catch
            {
                return true;
            }
        }
        public DataTable getPatients(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deletePatients(string patientsID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Patients WHERE patientsID = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = patientsID;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updatePatients(Patients patients)
        {
            SqlCommand command = new SqlCommand("UPDATE Patients SET fullName=@fn, gender=@gd, birthDate=@bdt, " +
                "persionalID=@perID, phoneNumber=@phn, address=@add, image=@image WHERE patientsID=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = patients.PatientsID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = patients.FullName;
            command.Parameters.Add("@gd", SqlDbType.NVarChar).Value = patients.Gender;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = patients.BirthDate;
            command.Parameters.Add("@perID", SqlDbType.VarChar).Value = patients.PersionalID;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = patients.PhoneNumber;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = patients.Address;
            command.Parameters.Add("@image", SqlDbType.Image).Value = patients.Image.ToArray();

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool insertPatients(Patients patients)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Patients (patientsID, fullName, gender, birthDate, persionalID, phoneNumber, address, image)" +
                " VALUES (@id,@fn, @gd, @bdt, @perID, @phn, @add, @image)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = patients.PatientsID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = patients.FullName;
            command.Parameters.Add("@gd", SqlDbType.NVarChar).Value = patients.Gender;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = patients.BirthDate;
            command.Parameters.Add("@perID", SqlDbType.VarChar).Value = patients.PersionalID;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = patients.PhoneNumber;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = patients.Address;
            command.Parameters.Add("@image", SqlDbType.Image).Value = patients.Image.ToArray();

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
