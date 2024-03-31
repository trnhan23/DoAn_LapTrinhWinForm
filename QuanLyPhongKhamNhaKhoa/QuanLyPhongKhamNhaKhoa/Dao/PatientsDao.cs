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
    internal class PatientsDao
    {
        SQLConnectionData mydb = new SQLConnectionData();

        public DataTable getPatients(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deletePatients(Patients patients)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Patients WHERE patientsID = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = patients.PatientsID;
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
                "persionalID=@perID, phoneNumber=@phn, address=@add where patientsID=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = patients.PatientsID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = patients.FullName;
            command.Parameters.Add("@gd", SqlDbType.NVarChar).Value = patients.Gender;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = patients.BirthDate;
            command.Parameters.Add("@perID", SqlDbType.VarChar).Value = patients.PersionalID;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = patients.PhoneNumber;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = patients.Address;

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
            SqlCommand command = new SqlCommand("INSERT INTO Patients (patientsID, fullName, gender, birthDate, persionalID, phoneNumber, address)" +
                " VALUES (@id,@fn, @gd, @bdt, @perID, @phn, @add)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = patients.PatientsID;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = patients.FullName;
            command.Parameters.Add("@gd", SqlDbType.NVarChar).Value = patients.Gender;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = patients.BirthDate;
            command.Parameters.Add("@perID", SqlDbType.VarChar).Value = patients.PersionalID;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = patients.PhoneNumber;
            command.Parameters.Add("@add", SqlDbType.NVarChar).Value = patients.Address;

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
    }
}
