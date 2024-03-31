using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa.Entity
{
    public class Medicine_Treatment
    {
        private string treatmentID;
        private string medicineID;
        private int amount;

        public string TreatmentID { get { return treatmentID; } set { treatmentID = value; } }
        public string MedicineID { get { return medicineID; } set {medicineID = value; } }
        public int Amount { get { return amount; } set { amount = value; } }

    }
}
