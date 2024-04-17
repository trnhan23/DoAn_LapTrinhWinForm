using QuanLyPhongKhamNhaKhoa.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyPhongKhamNhaKhoa.Dao
{
    internal class AppointmentDao
    {
        SQLConnectionData mydb = new SQLConnectionData();
        private Random random = new Random();

        public string taoMaAppointment()
        {
            const string chars = "0123456789";
            string result;
            do
            {
                string randomPart = new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
                result = $"APPO{randomPart}";

            } while (existAppointment(result));
            return result;
        }
        public bool existAppointment(string id)
        {
            try
            {
                mydb.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Appointment WHERE appointmentID = @appointmentID", mydb.getConnection);
                command.Parameters.Add("@appointmentID", SqlDbType.VarChar).Value = id;
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
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = appointment.Status;

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

        /*public bool insertAppointment(Appointment appointment)
        {
            DateTime startTime;
            DateTime endTime;

            if (!DateTime.TryParseExact(appointment.StartTime, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime) ||
                !DateTime.TryParseExact(appointment.EndTime, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime))
            {
                return false;
            }

            SqlCommand command = new SqlCommand("INSERT INTO Appointment (appointmentID, patientsID, userID, appointmentDate, startTime, endTime, status)" +
                " VALUES (@appointmentID,@patientsID, @userID, @appointmentDate, @startTime, @endTime, @status)", mydb.getConnection);
            command.Parameters.Add("@appointmentID", SqlDbType.VarChar).Value = appointment.AppointmentID;
            command.Parameters.Add("@patientsID", SqlDbType.VarChar).Value = appointment.PatientsID;
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = appointment.UserID;
            command.Parameters.Add("@appointmentDate", SqlDbType.DateTime).Value = appointment.AppointmentDate;
            command.Parameters.Add("@startTime", SqlDbType.DateTime).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.DateTime).Value = endTime;
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = appointment.Status;

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
        }*/
        public bool insertAppointment(string id, string patientid, string userid, DateTime date, string timestart, string timend, string status)
        {
            DateTime startTime = DateTime.ParseExact(timestart, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime endTime = DateTime.ParseExact(timend, "HH:mm:ss", CultureInfo.InvariantCulture);

            SqlCommand command = new SqlCommand("INSERT INTO Appointment (appointmentID, patientsID, userID, appointmentDate, startTime, endTime, status)" +
                " VALUES (@appointmentID,@patientsID, @userID, @appointmentDate, @startTime, @endTime, @status)", mydb.getConnection);
            command.Parameters.Add("@appointmentID", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@patientsID", SqlDbType.VarChar).Value = patientid;
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = userid;
            command.Parameters.Add("@appointmentDate", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@startTime", SqlDbType.DateTime).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.DateTime).Value = endTime;
            command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;

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
