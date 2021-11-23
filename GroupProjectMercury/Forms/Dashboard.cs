using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GroupProjectMercury.Forms;

namespace GroupProjectMercury
{
    public partial class Dashboard : Form
    {
        private Controller controller;
        private List<FlowLayoutPanel> listFlDay;
        private int currentID;
        private Employee currentEmp;
        private DateTime currentDate;
        private DateTime selectedDate;
        private List<Button> buttons;
        private List<Button> prefButtons;
        private Holiday holiday;

        public Dashboard(int id)
        {
            InitializeComponent();
            CustomDropDown();
            currentID = id;
            controller = new Controller(currentID);
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentID);
            listFlDay = new List<FlowLayoutPanel>();
            buttons = new List<Button>();
            prefButtons = new List<Button>();
            holiday = new Holiday();
            currentDate = DateTime.Today;
            GenerateDayPanel(42);
            DisplayCurrentDate();

            // Set the welcome name in the label
            lblWelcomeName.Text = currentEmp.FirstName + " " + currentEmp.LastName;

            // set navbar buttons visibility
            if (currentEmp.Position == "administrator")
            {
                btnEmployee.Visible = true;
                btnDepot.Visible = true;
                generateSchedulebtn.Visible = true;
                shiftsbttn.Visible = false;
                preferencesbttn.Visible = false;
            }
            else if (currentEmp.Position == "manager")
            {
                btnEmployee.Visible = true;
                btnDepot.Visible = false;
                generateSchedulebtn.Visible = false;
                shiftsbttn.Visible = false;
                preferencesbttn.Visible = false;
            }
            else if (currentEmp.Position == "shopworker")
            {
                btnEmployee.Visible = false;
                btnDepot.Visible = true;
                generateSchedulebtn.Visible = false;
                shiftsbttn.Visible = true;
                preferencesbttn.Visible = true;
                currentEmp.SetPreferences(controller.GetPreferencesByEmployee(currentID));
            }
            else
            {
                btnEmployee.Visible = false;
                btnDepot.Visible = true;
                generateSchedulebtn.Visible = false;
                shiftsbttn.Visible = true;
                preferencesbttn.Visible = true;
                currentEmp.SetPreferences(controller.GetPreferencesByEmployee(currentID));
            }
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
            if ((currentEmp.Position == "administrator") || (currentEmp.Position == "manager"))
            {
                AddLabelDayAndButtonToFlDayForOverview(firstDayAtFlNumber, totalDay);
            }
            else
            {
                AddLabelDayAndButtonToFlDay(firstDayAtFlNumber, totalDay);
            }           
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
                lbl.Size = new Size(82, 16);
                lbl.Text = i.ToString();
                lbl.Font = new Font("Microsoft Sans Serif", 10);
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

                List<DateTime> holidays = holiday.GetHolidays();
                if (holidays.Contains(selectedDate))
                {
                    listFlDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.Red;
                }
                else
                {
                    if (ScheduleDatabase.CheckDateOfShift(currentID, selectedDate) != null)
                    {
                        List<Shift> tempShifts = ScheduleDatabase.GetShiftsPerIdAndDate(ScheduleDatabase.GetShiftsPerId(currentID), selectedDate);
                        foreach (Shift s in tempShifts)
                        {
                            // add button to panel
                            listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                            listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(button);
                            button.Text = ScheduleDatabase.CheckDateOfShift(currentID, selectedDate).TimeOfDay;
                            button.BackColor = Color.Yellow;
                            button.Size = new Size(110, 22);
                            buttons.Add(button);
                        }
                    }
                }

                // color current day blue
                if (new DateTime(currentDate.Year, currentDate.Month, i) == DateTime.Today)
                {
                    listFlDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.Aqua;
                }                
            }
        }

        public void AddPreferencesLabelDayAndButtonToFlDay(int startDayAtFlNumber, int totalDaysInMonth)
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
                lbl.Size = new Size(82, 16);
                lbl.Text = i.ToString();
                lbl.Font = new Font("Microsoft Sans Serif", 10);
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
                               
                // color current day blue
                if (new DateTime(currentDate.Year, currentDate.Month, i) == DateTime.Today)
                {
                    listFlDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.Aqua;
                }

                //add preferences
                Button prefButton = button;

                DateTime referenceDate = DateTime.Now;
                DateTime prefDate = referenceDate.AddMonths(1);

                if (selectedDate.Month == prefDate.Month)
                {
                    //add buttons for preferences
                    if (controller.CheckPrefDay(currentID, selectedDate) == false)
                    {
                        prefButton.Click += preButton_click;
                        listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                        listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(prefButton);
                        prefButton.Text = "Add";
                        prefButton.BackColor = Color.Gray;
                        prefButton.Size = new Size(110, 22);
                        prefButtons.Add(prefButton);
                    }
                    else
                    {
                        listFlDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.Gray;
                    }
                }
            }
        }

        private void preButton_click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
            foreach (Button b in prefButtons)
            {
                if (b.Name == s)
                {
                    string date = s + lblMonthAndYear.Text;
                    selectedDate = DateTime.Parse(date);
                }
            }
            
            if(controller.SendPreferences(currentID, selectedDate))
            {
                currentEmp.AddPreference(selectedDate);
                MessageBox.Show("Preference successfully recorded !");
            }
            else
            {
                MessageBox.Show("Something went wrong! Preference couldn't be recorded ! ! !");
            }
            (sender as Button).Visible = false;
        }

        private void ShowShiftDetail(DateTime date)
        {
            ManageShifts manageShifts = new ManageShifts(currentID, date);
            manageShifts.Show();
            manageShifts.BringToFront();
            this.Close();
            //DisplayCurrentDate();
        }

        private void button_click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
            foreach (Button b in buttons)
            {
                if (b.Name == s)
                {
                    string date = s + lblMonthAndYear.Text;
                    selectedDate = DateTime.Parse(date);
                }
            }

            ShowShiftDetail(selectedDate);
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            ViewAnnouncement viewAnnouncement = new ViewAnnouncement(currentID);
            viewAnnouncement.Show();
        }

        private void generateSchedulebtn_Click(object sender, EventArgs e)
        {

            controller.GetScheduleController().GenerateAutoSchedule();
            MessageBox.Show("Schedule successfully generated ! ! !");
            // TODO: update/refresh GUI
        }


        public void AddLabelDayAndButtonToFlDayForOverview(int startDayAtFlNumber, int totalDaysInMonth)
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
                lbl.Size = new Size(82, 16);
                lbl.Text = i.ToString();
                lbl.Font = new Font("Microsoft Sans Serif", 10);

                // get flpanel of each day
                listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(lbl);

                // add button to each panel
                Button button = new Button();
                button.Name = i.ToString();
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.BackColor = Color.Yellow;
                button.Size = new Size(110, 22);

                string date = button.Name + lblMonthAndYear.Text;
                DateTime selectedDate = DateTime.Parse(date);

                List<DateTime> holidays = holiday.GetHolidays();
                if (holidays.Contains(selectedDate))
                {
                    listFlDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.Red;
                }
                else
                {
                    button.Text = $"{controller.GetScheduleController().GetCountOfShiftsPerDateAndTime(selectedDate, "morning")} : {controller.GetScheduleController().GetCountOfShiftsPerDateAndTime(selectedDate, "afternoon")} : {controller.GetScheduleController().GetCountOfShiftsPerDateAndTime(selectedDate, "evening")}"; ;

                    System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                    ToolTip1.SetToolTip(button, "morning : afternoon : evening");

                    // raise event
                    button.Click += button_click;

                    // add button to panel
                    listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                    listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(button);
                    buttons.Add(button);
                }

                // color current day blue
                if (new DateTime(currentDate.Year, currentDate.Month, i) == DateTime.Today)
                {
                    listFlDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.Aqua;
                }
            }
        }

        private void shiftsbttn_Click(object sender, EventArgs e)
        {
            lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy");
            int firstDayAtFlNumber = GetFirstDayOfWeekOfCurrentDate();
            int totalDay = GetTotalDaysOfCurrentDate();

            AddLabelDayAndButtonToFlDay(firstDayAtFlNumber, totalDay);
        }

        private void preferencesbttn_Click(object sender, EventArgs e)
        {
            lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy");
            int firstDayAtFlNumber = GetFirstDayOfWeekOfCurrentDate();
            int totalDay = GetTotalDaysOfCurrentDate();

            AddPreferencesLabelDayAndButtonToFlDay(firstDayAtFlNumber, totalDay);
        }

        // ------------- navbar on top
        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            DisplayCurrentDate();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
            DisplayCurrentDate();
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            DisplayCurrentDate();
        }

        //---------------- for nav bar
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(currentID);
            profile.Show();
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ViewEmployee viewEmployee = new ViewEmployee(currentID);
            viewEmployee.Show();
            this.Close();
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            Depot depot = new Depot(currentID);
            depot.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        //------------------ for navbar DESIGN
        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            DropDownExtend();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            DropDownCollapse();
        }

        private void CustomDropDown()
        {
            pDropDown.Size = MinimumSize;
        }

        private void DropDownExtend()
        {
            pDropDown.Size = MaximumSize;
        }

        private void DropDownCollapse()
        {
            pDropDown.Size = MinimumSize;
        }
    }
}
