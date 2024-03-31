using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa.Entity
{
    public class Service
    {
        private string serviceID;
        private string serviceName;
        private float cost;

        public string ServiceID { get { return serviceID; } set { serviceID = value; } }
        public string ServiceName { get { return serviceName; } set { serviceName = value; } }
        public float Cost { get { return cost; } set { cost = value; } }
    }
}
