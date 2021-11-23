using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectMercury.Forms
{
    public partial class IndividualSchedule : Form
    {
        private int manageId;
        private Controller controller;
        private List<FlowLayoutPanel> listFlDay;
        private List<Button> buttons;
        private DateTime currentDate;

        public IndividualSchedule(int empid)
        {
            InitializeComponent();
            this.manageId = empid;
            controller = new Controller(manageId);
            listFlDay = new List<FlowLayoutPanel>();
            buttons = new List<Button>();
            currentDate = DateTime.Today;

            lblEmpName.Text = EmployeeDatabase.GetEmployeeByID(manageId).FirstName + " " + EmployeeDatabase.GetEmployeeByID(manageId).LastName;

            GenerateDayPanel(42);
            DisplayCurrentDate();
        }

        // methods for calendar:
        private int GetFirstDayOfWeekOfCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            return Convert.ToInt32(firstDayOfMonth.DayOfWeek + 1);
        }

        private int GetTotalDaysOfCurrentDate()
        {
            DateTime firstDayOfCurrentDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day;
        }

        public void DisplayCurrentDate()
        {
            lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy");
            int firstDayAtFlNumber = GetFirstDayOfWeekOfCurrentDate();
            int totalDay = GetTotalDaysOfCurrentDate();

            AddLabelDayAndButtonToFlDay(firstDayAtFlNumber, totalDay);            
        }

        public void GenerateDayPanel(int totalDays)
        {
            flDays.Controls.Clear();
            listFlDay.Clear();
            for (int i = 1; i < totalDays + 1; i++)
            {
                FlowLayoutPanel fl = new FlowLayoutPanel();
                fl.Name = $"flDay{i}";
                fl.Size = new Size(125, 85);
                fl.BackColor = Color.White;
                fl.BorderStyle = BorderStyle.FixedSingle;
                fl.AutoScroll = true;
                flDays.Controls.Add(fl);
                listFlDay.Add(fl);
            }
        }

        public void AddLabelDayAndButtonToFlDay(int startDayAtFlNumber, int totalDaysInMonth)
        {
            foreach (FlowLayoutPanel fl in listFlDay)
            {
                fl.Controls.Clear();
                fl.Tag = 0;
                fl.BackColor = Color.White;
            }

            for (int i = 1; i < totalDaysInMonth + 1; i++)
            {
                // add labed to each panel
                Label lbl = new Label();
                lbl.Name = i.ToString();
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Size = new Size(50, 12);
                lbl.Text = i.ToString();
                lbl.Font = new Font("Microsoft Sans Serif", 8);
                lbl.Anchor = (AnchorStyles.Top & AnchorStyles.Right);

                // get flpanel of each day
                listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(lbl);

                // add button to each panel
                Button button = new Button();
                button.Name = i.ToString();
                button.TextAlign = ContentAlignment.MiddleCenter;

                string date = button.Name + lblMonthAndYear.Text;
                DateTime selectedDate = DateTime.Parse(date);

                button.Text = $"{controller.GetScheduleController().GetCountOfShiftsPerDateAndTime(selectedDate, "morning")} : {controller.GetScheduleController().GetCountOfShiftsPerDateAndTime(selectedDate, "afternoon")} : {controller.GetScheduleController().GetCountOfShiftsPerDateAndTime(selectedDate, "evening")}";

                if (ScheduleDatabase.CheckDateOfShift(manageId, selectedDate) != null)
                {
                    List<Shift> tempShifts = ScheduleDatabase.GetShiftsPerIdAndDate(ScheduleDatabase.GetShiftsPerId(manageId), selectedDate);
                    foreach (Shift s in tempShifts)
                    {
                        // add button to panel
                        listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                        listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(button);
                        button.Text = ScheduleDatabase.CheckDateOfShift(manageId, selectedDate).TimeOfDay;
                        button.BackColor = Color.Yellow;
                        button.Size = new Size(110, 22);
                        buttons.Add(button);
                    }
                }

                // color current day blue
                if (new DateTime(currentDate.Year, currentDate.Month, i) == DateTime.Today)
                {
                    listFlDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.Aqua;
                }
            }
        }


        // ------------- navbar on top
        private void btnNextMonth_Click_1(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            DisplayCurrentDate();
        }

        private void btnPrevMonth_Click_1(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            DisplayCurrentDate();
        }

        private void btnToday_Click_1(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
            DisplayCurrentDate();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
