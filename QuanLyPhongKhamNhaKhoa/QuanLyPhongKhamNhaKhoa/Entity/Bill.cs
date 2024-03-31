using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKhamNhaKhoa.Entity
{
    public class Bill
    {
        private string billID;
        private string patientsID;
        private string treatmentID;
        private float totalCost;
        private DateTime exportBillDate;

        public string BillID { get { return billID; } set { billID = value; } }
        public string PatientsID { get { return patientsID; } set {patientsID = value; } }
        public string TreatmentID { get { return treatmentID; } set {treatmentID = value; } }
        public float TotalCost { get { return totalCost; } set { totalCost = value; } }
        public DateTime ExportBillDate { get { return exportBillDate; } set {exportBillDate = value; } }
    }
}
