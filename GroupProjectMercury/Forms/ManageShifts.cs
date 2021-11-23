using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectMercury.Forms
{
    public partial class ManageShifts : Form
    {
        private Controller controller;
        private int currentID;
        private DateTime selectedDate;
        private Employee currentEmp;
        List<Employee> tempEmployees;

        public ManageShifts(int id, DateTime date)
        {
            InitializeComponent();
            currentID = id;
            selectedDate = date;
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentID);
            controller = new Controller(currentID);

            // set datetimepicker to selected date
            dtpAssign.Value = selectedDate;

            // manager cannot assign employees to shifts, only administrator can
            if (currentEmp.Position == "manager")
            {
                gbxAssign.Visible = false;
            }
        }

        public void UpdateLists(string time)
        {
            lbxShopworkers.Items.Clear();
            lbxDepotworkers.Items.Clear(); 

            tempEmployees = controller.GetEmployeesPerShiftPerDateAndTime(selectedDate, time);
            List<ShopWorker> tempShopworker = new List<ShopWorker>();
            List<DepotWorker> tempDepotworker = new List<DepotWorker>();

            // get all shopworkers
            for (int i = 0; i < tempEmployees.Count; i++)
            {
                if (tempEmployees[i] is ShopWorker)
                {
                    tempShopworker.Add((ShopWorker)tempEmployees[i]);
                }
            }
            // display all shopworkers
            for (int i = 0; i < tempShopworker.Count; i++)
            {
                lbxShopworkers.Items.Add(tempShopworker[i].FirstName + " " + tempShopworker[i].LastName);
            }

            // get all depotworkers
            for (int i = 0; i < tempEmployees.Count; i++)
            {
                if (tempEmployees[i] is DepotWorker)
                {
                    tempDepotworker.Add((DepotWorker)tempEmployees[i]);
                }
            }
            // display all depotworkers
            for (int i = 0; i < tempDepotworker.Count; i++)
            {
                lbxDepotworkers.Items.Add(tempDepotworker[i].FirstName + " " + tempDepotworker[i].LastName);
            }

            // update count label
            lblTotalCount.Text = $"Total employees: {controller.GetScheduleController().GetCountOfShiftsPerDateAndTime(selectedDate, time)}";
        }

        private void rbtnDetailsMorning_CheckedChanged(object sender, EventArgs e)
        {        
            if (rbtnDetailsMorning.Checked)
            {
                UpdateLists("morning");
            }
        }

        private void rbtnDetailsAfternoon_CheckedChanged(object sender, EventArgs e)
        {          
            if (rbtnDetailsAfternoon.Checked)
            {
                UpdateLists("afternoon");
            }
        }

        private void rbtnDetailsEvening_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDetailsEvening.Checked)
            {
                UpdateLists("evening");
            }
        }

        private void btnAssignShift_Click_1(object sender, EventArgs e)
        {
            if (rbtnAssignMorning.Checked == false && rbtnAssignAfternoon.Checked == false && rbtnAssignEvening.Checked == false)
            {
                MessageBox.Show("Please select a time slot");
            }
            else if (rbtnShopworker.Checked == false && rbtnDepotworker.Checked == false)
            {
                MessageBox.Show("Please select a type of employee");
            }
            else if (cbxAssignEmployee.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an employee");
            }
            else
            {
                TimeSpan starttime;
                TimeSpan endtime;
                string timeofday;
                if (rbtnAssignMorning.Checked)
                {
                    starttime = new TimeSpan(09, 00, 00);
                    endtime = new TimeSpan(12, 00, 00);
                    timeofday = "morning";
                }
                else if (rbtnAssignAfternoon.Checked)
                {
                    starttime = new TimeSpan(12, 00, 00);
                    endtime = new TimeSpan(16, 00, 00);
                    timeofday = "afternoon";
                }
                else
                {
                    starttime = new TimeSpan(16, 00, 00);
                    endtime = new TimeSpan(21, 00, 00);
                    timeofday = "evening";
                }

                Shift shift = new Shift(Convert.ToInt32(cbxAssignEmployee.SelectedItem), dtpAssign.Value, starttime, endtime, timeofday);

                // check if employee is already assigned to a shift
                List<Shift> tempshifts = ScheduleDatabase.GetAllShifts();
                bool alreadyAssigned = false;
                for (int i = 0; i < tempshifts.Count; i++)
                {
                    if (tempshifts[i].EmpId == shift.EmpId && tempshifts[i].Date == shift.Date && tempshifts[i].TimeOfDay == shift.TimeOfDay)
                    {
                        alreadyAssigned = true;
                    }
                }

                if (!alreadyAssigned)
                {
                    if (!controller.AssignShift(shift))
                    {
                        MessageBox.Show("You dont have permission");
                    }
                    else
                    {
                        MessageBox.Show("Shift assigned successfully");

                        // clear input fields
                        cbxAssignEmployee.SelectedIndex = -1;
                        dtpAssign.Value = DateTime.Now;
                        rbtnAssignMorning.Checked = false;
                        rbtnAssignAfternoon.Checked = false;
                        rbtnAssignEvening.Checked = false;
                        rbtnShopworker.Checked = false;
                        rbtnDepotworker.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("This employee is already assigned to that shift");
                }
            }
        }

        private void rbtnShopworker_CheckedChanged(object sender, EventArgs e)
        {
            cbxAssignEmployee.Items.Clear();

            // fill combobox
            foreach (int id in controller.GetEmployeeController().LoadIDs())
            {
                Employee emp = EmployeeDatabase.GetEmployeeByID(id);
                if (emp.Position == "shopworker")
                {
                    cbxAssignEmployee.Items.Add($"{id}: {emp.FirstName} {emp.LastName}");
                }
            }
        }

        private void rbtnDepotworker_CheckedChanged(object sender, EventArgs e)
        {
            cbxAssignEmployee.Items.Clear();

            // fill combobox
            foreach (int id in controller.GetEmployeeController().LoadIDs())
            {
                Employee emp = EmployeeDatabase.GetEmployeeByID(id);
                if (emp.Position == "depotworker")
                {
                    cbxAssignEmployee.Items.Add($"{id}: {emp.FirstName} {emp.LastName}");
                }
            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(currentID);
            dashboard.Show();
            this.Close();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            
            if ((rbtnDetailsMorning.Checked == true) || (rbtnDetailsAfternoon.Checked == true) || (rbtnDetailsEvening.Checked == true))
            {
                if(lbxShopworkers.SelectedItem != null)
                {
                    Employee emp = controller.GetEmployeeController().GetEmployeeByString(Convert.ToString(lbxShopworkers.SelectedItem.ToString()));

                    if(rbtnDetailsMorning.Checked == true)
                    {
                       TimeSpan starttime = new TimeSpan(09, 00, 00);
                       TimeSpan endtime = new TimeSpan(12, 00, 00);
                       string timeofday = "morning";
                       Shift s = new Shift(emp.Id, selectedDate, starttime,endtime, timeofday);
                       controller.GetScheduleController().GetShiftManagement().RemoveShift(s);
                        UpdateLists(timeofday);
                    }
                    if(rbtnDetailsAfternoon.Checked == true)
                    {
                        TimeSpan starttime = new TimeSpan(12, 00, 00);
                        TimeSpan  endtime = new TimeSpan(16, 00, 00);
                        string timeofday = "afternoon";
                        Shift s = new Shift(emp.Id, selectedDate, starttime, endtime, timeofday);
                        controller.GetScheduleController().GetShiftManagement().RemoveShift(s);
                        UpdateLists(timeofday);
                    }
                    if(rbtnDetailsEvening.Checked == true)
                    {
                        TimeSpan starttime = new TimeSpan(16, 00, 00);
                        TimeSpan endtime = new TimeSpan(21, 00, 00);
                        string timeofday = "evening";
                        Shift s = new Shift(emp.Id, selectedDate, starttime, endtime, timeofday);
                        controller.GetScheduleController().GetShiftManagement().RemoveShift(s);
                        UpdateLists(timeofday);
                    }
                }
                else if(lbxDepotworkers.SelectedItem != null)
                {
                    Employee emp = controller.GetEmployeeController().GetEmployeeByString(lbxDepotworkers.SelectedItem.ToString());

                    if (rbtnDetailsMorning.Checked == true)
                    {
                        TimeSpan starttime = new TimeSpan(09, 00, 00);
                        TimeSpan endtime = new TimeSpan(12, 00, 00);
                        string timeofday = "morning";
                        Shift s = new Shift(emp.Id, selectedDate, starttime, endtime, timeofday);
                        controller.GetScheduleController().GetShiftManagement().RemoveShift(s);
                        UpdateLists(timeofday);
                    }
                    if (rbtnDetailsAfternoon.Checked == true)
                    {
                        TimeSpan starttime = new TimeSpan(12, 00, 00);
                        TimeSpan endtime = new TimeSpan(16, 00, 00);
                        string timeofday = "afternoon";
                        Shift s = new Shift(emp.Id, selectedDate, starttime, endtime, timeofday);
                        controller.GetScheduleController().GetShiftManagement().RemoveShift(s);
                        UpdateLists(timeofday);
                    }
                    if (rbtnDetailsEvening.Checked == true)
                    {
                        TimeSpan starttime = new TimeSpan(16, 00, 00);
                        TimeSpan endtime = new TimeSpan(21, 00, 00);
                        string timeofday = "evening";
                        Shift s = new Shift(emp.Id, selectedDate, starttime, endtime, timeofday);
                        controller.GetScheduleController().GetShiftManagement().RemoveShift(s);
                        UpdateLists(timeofday);
                    }
                }

                
            }
            else
            {
                MessageBox.Show("An employee must be selected ! ! !");
            }
        }




        //generate file to print out shift per (selected) date

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            string fileName;
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
                if (WriteFile(fileName))
                {
                    MessageBox.Show("Saved succesfully");
                }
                else
                {
                    MessageBox.Show("Couldn't save file");
                }
            }
            else { MessageBox.Show("Saving cancelled"); }
        }


        public bool WriteFile(string filename)
        {
            StreamWriter streamWriter = null;

            bool success = false;

            try
            {
                FileStream fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);

                streamWriter.WriteLine(selectedDate.ToShortDateString());
                streamWriter.WriteLine("Morning");
                foreach (Employee e in controller.GetEmployeesPerShiftPerDateAndTime(selectedDate, "morning"))
                {
                    streamWriter.WriteLine(e.ToString());
                }
                streamWriter.WriteLine("Afternoon");
                foreach (Employee e in controller.GetEmployeesPerShiftPerDateAndTime(selectedDate, "afternoon"))
                {
                    streamWriter.WriteLine(e.ToString());
                }
                streamWriter.WriteLine("Evening");
                foreach (Employee e in controller.GetEmployeesPerShiftPerDateAndTime(selectedDate, "evening"))
                {
                    streamWriter.WriteLine(e.ToString());
                }

                success = true;
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

            return success;
        }
    }
}
