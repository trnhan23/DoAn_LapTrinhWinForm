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
    internal class UserDao
    {
        SQLConnectionData mydb = new SQLConnectionData();

        public DataTable getUsers(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteUsers(User user)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Users WHERE userID = @userID", mydb.getConnection);
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = user.UserID;
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

        public bool updateUsers(User user)
        {
            SqlCommand command = new SqlCommand("UPDATE Users SET fullName=@fullName, " +
                "gender=@gender, birthDate=@birthDate, persionalID=@persionalID, phoneNumber=@phoneNumber, " +
                "address=@address, isDoctor=@isDoctor, isAdmin=@isAdmin, password=@password " +
                "WHERE userID=@userID", mydb.getConnection);
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = user.UserID;
            command.Parameters.Add("@fullName", SqlDbType.NVarChar).Value = user.FullName;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = user.Gender;
            command.Parameters.Add("@birthDate", SqlDbType.DateTime).Value = user.BirthDate;
            command.Parameters.Add("@persionalID", SqlDbType.VarChar).Value = user.PersionalID;
            command.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = user.PhoneNumber;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = user.Address;
            command.Parameters.Add("@isDoctor", SqlDbType.Bit).Value = user.IsDoctor;
            command.Parameters.Add("@isAdmin", SqlDbType.Bit).Value = user.IsAdmin;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = user.Password;

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

        public bool insertUsers(User user)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Users (userID, fullName, gender, birthDate, persionalID, phoneNumber, address, isDoctor, isAdmin, password)" +
                " VALUES (@userID,@fullName, @gender, @birthDate, @persionalID, @phoneNumber, @address, @isDoctor, @isAdmin, @password)", mydb.getConnection);
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = user.UserID;
            command.Parameters.Add("@fullName", SqlDbType.NVarChar).Value = user.FullName;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = user.Gender;
            command.Parameters.Add("@birthDate", SqlDbType.DateTime).Value = user.BirthDate;
            command.Parameters.Add("@persionalID", SqlDbType.VarChar).Value = user.PersionalID;
            command.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = user.PhoneNumber;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = user.Address;
            command.Parameters.Add("@isDoctor", SqlDbType.Bit).Value = user.IsDoctor;
            command.Parameters.Add("@isAdmin", SqlDbType.Bit).Value = user.IsAdmin;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = user.Password;


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
