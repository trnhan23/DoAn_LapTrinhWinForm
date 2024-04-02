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
    internal class BillDao
    {
        SQLConnectionData mydb = new SQLConnectionData();

        public DataTable getBill(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteAppointment(Bill bill)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Bill WHERE billID=@billID", mydb.getConnection);
            command.Parameters.Add("@billID", SqlDbType.VarChar).Value = bill.BillID;
            
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

        public bool updateBill(Bill bill)
        {
            SqlCommand command = new SqlCommand("UPDATE Bill SET patientsID=@patientsID, treatmentID=@treatmentID, " +
                "totalCost=@totalCost, exportBillDate=@exportBillDate " +
                "WHERE billID=@billID", mydb.getConnection);
            command.Parameters.Add("@billID", SqlDbType.VarChar).Value = bill.BillID;
            command.Parameters.Add("@patientsID", SqlDbType.VarChar).Value = bill.PatientsID;
            command.Parameters.Add("@treatmentID", SqlDbType.VarChar).Value = bill.TreatmentID;
            command.Parameters.Add("@totalCost", SqlDbType.Float).Value = bill.TotalCost;
            command.Parameters.Add("@exportBillDate", SqlDbType.DateTime).Value = DateTime.Now;

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

        public bool insertBill(Bill bill)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Bill (billID, patientsID, treatmentID, totalCost, exportBillDate)" +
                " VALUES (@billID, @patientsID, @treatmentID, @totalCost, @exportBillDate)", mydb.getConnection);
            command.Parameters.Add("@billID", SqlDbType.VarChar).Value = bill.BillID;
            command.Parameters.Add("@patientsID", SqlDbType.VarChar).Value = bill.PatientsID;
            command.Parameters.Add("@treatmentID", SqlDbType.VarChar).Value = bill.TreatmentID;
            command.Parameters.Add("@totalCost", SqlDbType.Float).Value = bill.TotalCost;
            command.Parameters.Add("@exportBillDate", SqlDbType.DateTime).Value = DateTime.Now;

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
