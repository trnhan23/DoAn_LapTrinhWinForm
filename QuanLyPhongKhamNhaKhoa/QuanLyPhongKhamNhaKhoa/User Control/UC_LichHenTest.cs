using QuanLyPhongKhamNhaKhoa.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKhamNhaKhoa.User_Control
{
    public partial class UC_LichHenTest : UserControl
    {
        private TableLayoutPanel tableLayoutPanel;
        private Label[] timeLabels;
        private Label[] dayLabels;
        private Panel[,] schedulePanels;
        private DateTime currentDate = DateTime.Today;
        private const int RowHeight = 60; // Chiều cao cho mỗi dòng

        private static UC_LichHenTest _instance;
        Contants cons = new Contants();
        public static UC_LichHenTest Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_LichHenTest();
                return _instance;
            }
        }
        public UC_LichHenTest()
        {
            InitializeComponent();
            InitializeCalendar();
        }
        private void InitializeCalendar()
        {
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.AutoScroll = true;

            // Thiết lập cột cho TableLayoutPanel
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100)); // Cột cho thời gian
            for (int i = 0; i < 7; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / 7));
            }

            // Thiết lập dòng cho TableLayoutPanel
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30)); // Dòng cố định cho thứ
            for (int i = 0; i < 10; i++) // 9 dòng cho khoảng thời gian từ 8h đến 16h
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Dòng cho thời gian
            }

            // Thêm thời gian vào TableLayoutPanel
            timeLabels = new Label[10];
            for (int hour = 7; hour <= 16; hour++)
            {
                Label timeLabel = new Label
                {
                    Text = $"{hour}:00",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    ForeColor = Color.Blue
                };
                tableLayoutPanel.Controls.Add(timeLabel, 0, hour - 7);
                timeLabels[hour - 7] = timeLabel;
            }

            // Thêm các ngày vào TableLayoutPanel
            dayLabels = new Label[7];
            DateTime startDate = currentDate.AddDays(-(int)currentDate.DayOfWeek + (int)DayOfWeek.Monday);
            for (int i = 0; i < 7; i++)
            {
                string dayName = startDate.AddDays(i).ToString("ddd d/M");
                dayLabels[i] = new Label
                {
                    Text = dayName,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel.Controls.Add(dayLabels[i], i + 1, 0);
            }

            // Thêm các Panel cho việc lên lịch
            schedulePanels = new Panel[7, 9];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    schedulePanels[i, j] = new Panel
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Dock = DockStyle.Fill
                    };
                    tableLayoutPanel.Controls.Add(schedulePanels[i, j], i + 1, j + 1);
                }
            }

            // Thêm TableLayoutPanel vào Panel đã thiết kế
            Panel panel = this.Controls["panelDate"] as Panel;
            if (panel != null)
            {
                panel.Controls.Add(tableLayoutPanel);
            }

            UpdateCalendar();

        }
        private void UpdateCalendar()
        {
            for (int i = 0; i < 7; i++)
            {
                string dayName = currentDate.AddDays(-(int)currentDate.DayOfWeek + (int)DayOfWeek.Monday + i).ToString("ddd d");
                dayLabels[i].Text = dayName;
            }
            tableLayoutPanel.Controls.Remove(dayLabels[0]);
            tableLayoutPanel.Controls.Add(dayLabels[0], 1, 0);
            tableLayoutPanel.Controls.SetChildIndex(dayLabels[0], 8);

            Label monthYearLabel = tableLayoutPanel.Controls[0] as Label;
            if (monthYearLabel != null)
            {
                monthYearLabel.Text = currentDate.ToString("MMMM yyyy");
            }
        }
    }
}
