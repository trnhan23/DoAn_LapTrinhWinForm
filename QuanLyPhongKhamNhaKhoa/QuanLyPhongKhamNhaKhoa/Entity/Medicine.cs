using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa.Entity
{
    public class Medicine
    {
        private string medicineID;
        private string medicineName;
        private float cost;

        public string MedicineID { get { return medicineID; } set { medicineID = value; } }
        public string MedicineName { get { return medicineName; } set {medicineName = value; } }
        public float Cost { get { return cost; } set { cost = value; } }
    }
}
