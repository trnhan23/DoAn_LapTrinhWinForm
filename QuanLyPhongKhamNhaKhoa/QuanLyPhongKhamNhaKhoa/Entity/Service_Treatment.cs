using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa.Entity
{
    public class Service_Treatment
    {
        private string treatmentID;
        private string serviceID;

        public string TreatmentID { get { return treatmentID; } set { treatmentID = value; } }
        public string ServiceID { get { return serviceID; } set { serviceID = value; } }
    }
}
