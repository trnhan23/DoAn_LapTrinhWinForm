using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKhamNhaKhoa.Entity;

namespace QuanLyPhongKhamNhaKhoa.Dao
{
    class ServiceDao
    {
        SQLConnectionData mydb = new SQLConnectionData();
        private Random random = new Random();
        Service service = new Service();
        public DataTable getSerivce(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public string taoMaService()
        {
            const string chars = "0123456789";
            string result;
            do
            {
                string randomPart = new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());
                result = $"SERV{randomPart}";
            } while (existService(result));
            return result;
        }
        public bool updateService(Service service)
        {
            SqlCommand command = new SqlCommand("UPDATE Service SET serviceName=@serviceName, unit=@unit, cost=@cost WHERE serviceID=@serviceID", mydb.getConnection);
            command.Parameters.Add("@serviceID", SqlDbType.VarChar).Value = service.ServiceID;
            command.Parameters.Add("@serviceName", SqlDbType.NVarChar).Value = service.ServiceName;
            command.Parameters.Add("@unit", SqlDbType.NVarChar).Value = service.Unit;
            command.Parameters.Add("@cost", SqlDbType.Float).Value = service.Cost;

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
        public bool insertService(Service service)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Service (serviceID, serviceName, unit, cost)" +
                " VALUES (@serviceID, @serviceName, @unit, @cost)", mydb.getConnection);
            command.Parameters.Add("@serviceID", SqlDbType.VarChar).Value = service.ServiceID;
            command.Parameters.Add("@serviceName", SqlDbType.NVarChar).Value = service.ServiceName;
            command.Parameters.Add("@unit", SqlDbType.NVarChar).Value = service.Unit;
            command.Parameters.Add("@cost", SqlDbType.Float).Value = service.Cost;
            
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
        public bool existService(string id)
        {
            try
            {
                mydb.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Service WHERE serviceID = @serviceID", mydb.getConnection);
                command.Parameters.Add("@serviceID", SqlDbType.VarChar).Value = id;
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
    }
}
