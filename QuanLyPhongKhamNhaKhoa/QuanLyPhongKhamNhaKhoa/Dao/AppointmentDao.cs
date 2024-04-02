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
    internal class AppointmentDao
    {
        SQLConnectionData mydb = new SQLConnectionData();

        public DataTable getAppointment(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteAppointment(Appointment appointment)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Appointment WHERE appointmentID=@appointmentID and patientsID=@patientsID and userID=@userID", mydb.getConnection);
            command.Parameters.Add("@appointmentID", SqlDbType.VarChar).Value = appointment.AppointmentID;
            command.Parameters.Add("@patientsID", SqlDbType.VarChar).Value = appointment.PatientsID;
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = appointment.UserID;
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

        public bool updateAppointment(Appointment appointment)
        {
            SqlCommand command = new SqlCommand("UPDATE Appointment SET patientsID=@patientsID, userID=@userID, appointmentDate=@appointmentDate," +
                " startTime=@startTime, endTime=@endTime, status=@status " +
                "WHERE appointmentID=@appointmentID", mydb.getConnection);
            command.Parameters.Add("@appointmentID", SqlDbType.VarChar).Value = appointment.AppointmentID;
            command.Parameters.Add("@patientsID", SqlDbType.VarChar).Value = appointment.PatientsID;
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = appointment.UserID;
            command.Parameters.Add("@appointmentDate", SqlDbType.DateTime).Value = appointment.AppointmentDate;
            command.Parameters.Add("@startTime", SqlDbType.Time).Value = appointment.StartTime;
            command.Parameters.Add("@endTime", SqlDbType.Time).Value = appointment.EndTime;
            command.Parameters.Add("@status", SqlDbType.Bit).Value = appointment.Status;

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

        public bool insertAppointment(Appointment appointment)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Appointment (appointmentID, patientsID, userID, appointmentDate, startTime, endTime, status)" +
                " VALUES (@appointmentID,@patientsID, @userID, @appointmentDate, @startTime, @endTime, @status)", mydb.getConnection);
            command.Parameters.Add("@appointmentID", SqlDbType.VarChar).Value = appointment.AppointmentID;
            command.Parameters.Add("@patientsID", SqlDbType.VarChar).Value = appointment.PatientsID;
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = appointment.UserID;
            command.Parameters.Add("@appointmentDate", SqlDbType.DateTime).Value = appointment.AppointmentDate;
            command.Parameters.Add("@startTime", SqlDbType.Time).Value = appointment.StartTime;
            command.Parameters.Add("@endTime", SqlDbType.Time).Value = appointment.EndTime;
            command.Parameters.Add("@status", SqlDbType.Bit).Value = appointment.Status;

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
