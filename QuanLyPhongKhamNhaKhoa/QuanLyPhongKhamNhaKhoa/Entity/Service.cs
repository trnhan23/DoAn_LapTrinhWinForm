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
        private string unit;
        private float cost;
        public Service() { }
        public Service(string serviceID, string serviceName, string unit, float cost)
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.unit = unit;
            this.cost = cost;
        }
        public string ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string Unit { get; set; }
        public float Cost { get; set; }
    }
}
