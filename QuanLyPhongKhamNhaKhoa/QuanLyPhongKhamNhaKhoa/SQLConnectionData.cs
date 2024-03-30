using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa
{
    internal class SQLConnectionData
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DentalClinic;Integrated Security=True;Encrypt=False");
        
        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }

    }
}
