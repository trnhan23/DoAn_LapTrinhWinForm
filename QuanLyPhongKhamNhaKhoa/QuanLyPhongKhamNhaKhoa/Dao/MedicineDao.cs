using QuanLyPhongKhamNhaKhoa.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa.Dao
{
    internal class MedicineDao
    {
        SQLConnectionData mydb = new SQLConnectionData();


        public DataTable getMedicine(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteMedicine(Medicine medicine)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Medicine WHERE medicineID=@medicineID", mydb.getConnection);
            command.Parameters.Add("@medicineID", SqlDbType.VarChar).Value = medicine.MedicineID;
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

        public bool updateMedicine(Medicine medicine)
        {
            SqlCommand command = new SqlCommand("UPDATE Medicine SET medicineID=@medicineID, medicineName=@medicineName, cost=@cost" +
                "WHERE medicineID=@medicineID", mydb.getConnection);
            command.Parameters.Add("@medicineID", SqlDbType.VarChar).Value = medicine.MedicineID;
            command.Parameters.Add("@medicineName", SqlDbType.NVarChar).Value = medicine.MedicineName;
            command.Parameters.Add("@cost", SqlDbType.Float).Value = medicine.Cost;

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

        public bool insertMedicine(Medicine medicine)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Medicine (medicineID, medicineName, cost)" +
                " VALUES (@medicineID,@medicineName, @cost)", mydb.getConnection);
            command.Parameters.Add("@medicineID", SqlDbType.VarChar).Value = medicine.MedicineID;
            command.Parameters.Add("@medicineName", SqlDbType.NVarChar).Value = medicine.MedicineName;
            command.Parameters.Add("@cost", SqlDbType.Float).Value = medicine.Cost;

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
