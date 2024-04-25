using QuanLyPhongKhamNhaKhoa.FormXuLyLichHen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKhamNhaKhoa
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            /*LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();*/

            Application.Run(new MainForm());
        }

    }
}
