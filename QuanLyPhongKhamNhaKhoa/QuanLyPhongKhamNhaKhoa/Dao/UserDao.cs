using QuanLyPhongKhamNhaKhoa.Entity;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace QuanLyPhongKhamNhaKhoa.Dao
{
    internal class UserDao
    {
        SQLConnectionData mydb = new SQLConnectionData();
        private Random random = new Random();

        public DataTable getAllDentist()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE isRole = 'DENTIST'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public string taoPassword()
        {
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string specialChars = "!@#$%^&*()-_=+";
            const string chars = "0123456789";

            char specialChar = specialChars[random.Next(specialChars.Length)];

            char upperChar = upperChars[random.Next(upperChars.Length)];

            char lowerChar1 = lowerChars[random.Next(lowerChars.Length)];
            char lowerChar2 = lowerChars[random.Next(lowerChars.Length)];

            string randomPart = new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());

            string password = $"{specialChar}{upperChar}{lowerChar1}{lowerChar2}{randomPart}";
            password = new string(password.ToCharArray().OrderBy(x => random.Next()).ToArray());

            return password;
        }

        public string taoMaUsers(string chucVu)
        {
            const string chars = "0123456789";
            string result;
            do
            {
                string randomPart = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());
                if (chucVu.Equals("ADMIN"))
                {
                    result = $"ADMI{randomPart}";
                }
                else if (chucVu.Equals("DENTIST"))
                {
                    result = $"DENT{randomPart}";
                }
                else if (chucVu.Equals("ASSISTANT"))
                {
                    result = $"ASSI{randomPart}";
                }
                else
                {
                    result = $"USER{randomPart}";
                }
            } while (existUsers(result));
            return result;
        }
        public bool existUsers(string id)
        {
            try
            {
                mydb.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE userID = @userID", mydb.getConnection);
                command.Parameters.Add("@userID", SqlDbType.VarChar).Value = id;
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
        public bool existPersionalIDUsers(string persionalID)
        {
            try
            {
                mydb.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE persionalID = @persionalID", mydb.getConnection);
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
        public bool existEmailUsers(string email)
        {
            try
            {
                mydb.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE email = @email", mydb.getConnection);
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
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
        public bool existPhoneUsers(string phone)
        {
            try
            {
                mydb.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE phoneNumber = @phoneNumber", mydb.getConnection);
                command.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = phone;
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
        public DataTable getUsers(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteUsers(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Users WHERE userID = @userID", mydb.getConnection);
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = id;
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
                "gender=@gender, birthDate=@birthDate, persionalID=@persionalID, phoneNumber=@phoneNumber, email=@email, " +
                "address=@address, isRole=@isRole, image=@image " +
                "WHERE userID=@userID", mydb.getConnection);
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = user.UserID;
            command.Parameters.Add("@fullName", SqlDbType.NVarChar).Value = user.FullName;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = user.Gender;
            command.Parameters.Add("@birthDate", SqlDbType.DateTime).Value = user.BirthDate;
            command.Parameters.Add("@persionalID", SqlDbType.VarChar).Value = user.PersionalID;
            command.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = user.PhoneNumber;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = user.Email;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = user.Address;
            command.Parameters.Add("@isRole", SqlDbType.NVarChar).Value = user.IsRole;
            command.Parameters.Add("@image", SqlDbType.Image).Value = user.Image.ToArray();

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
            SqlCommand command = new SqlCommand("INSERT INTO Users (userID, fullName, gender, birthDate, persionalID, phoneNumber, email, address, isRole, password, image)" +
                " VALUES (@userID,@fullName, @gender, @birthDate, @persionalID, @phoneNumber, @email, @address, @isRole, @password, @image)", mydb.getConnection);
            command.Parameters.Add("@userID", SqlDbType.VarChar).Value = user.UserID;
            command.Parameters.Add("@fullName", SqlDbType.NVarChar).Value = user.FullName;
            command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = user.Gender;
            command.Parameters.Add("@birthDate", SqlDbType.DateTime).Value = user.BirthDate;
            command.Parameters.Add("@persionalID", SqlDbType.VarChar).Value = user.PersionalID;
            command.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = user.PhoneNumber;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = user.Email;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = user.Address;
            command.Parameters.Add("@isRole", SqlDbType.NVarChar).Value = user.IsRole;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = user.Password;
            command.Parameters.Add("@image", SqlDbType.Image).Value = user.Image.ToArray();

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
        
        public User getUser(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); // Tạo DataTable để chứa dữ liệu từ cơ sở dữ liệu
            adapter.Fill(dt); // Lấy dữ liệu từ cơ sở dữ liệu và đổ vào DataTable

            // Kiểm tra nếu có dữ liệu trong DataTable
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Lấy dòng đầu tiên
                // Khởi tạo đối tượng User từ dữ liệu trong DataRow
                byte[] pic;
                MemoryStream picture;
                if (row["image"] == null || string.IsNullOrEmpty(row["image"].ToString()))
                {
                    picture = null;
                }
                else
                {
                    pic = (byte[])row["image"];
                    picture = new MemoryStream(pic);
                }
                User user = new User
                {
                    UserID = row["userID"].ToString(),
                    FullName = row["fullName"].ToString(),
                    BirthDate = Convert.ToDateTime(row["birthDate"]),
                    Gender = row["gender"].ToString(),
                    PersionalID = row["persionalID"].ToString(),
                    PhoneNumber = row["phoneNumber"].ToString(),
                    Email = row["email"].ToString(),
                    Address = row["address"].ToString(),
                    IsRole = row["isRole"].ToString(),
                    Password = row["password"].ToString(),
                    Image = picture
                };
                return user; // Trả về đối tượng User đã tạo
            }
            else
            {
                return null; // Trả về null nếu không có dữ liệu trong DataTable
            }
        }
    }
}
