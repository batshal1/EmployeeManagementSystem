using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GroupProjectMercury.Forms
{
    public partial class ManagingEmployee : Form
    {
        private EmployeeController employeeController;
        private DepartmentController departmentController;
        private int currentID;
        private Employee currentEmp;
        private Employee manageEmp;
        //private int loggedInId;
        private int manageId;

        public ManagingEmployee(int id, int manageId)
        {
            InitializeComponent();
            currentID = id;
            this.manageId = manageId;
            employeeController = new EmployeeController(currentID);
            // logged in emp
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentID);
            // manage id emp
            manageEmp = EmployeeDatabase.GetEmployeeByID(manageId);
            departmentController = new DepartmentController(id);
            // display information of the logged in employee
            UpdateInfo();

            //add departments to cbxDepartment
            foreach(Department department in departmentController.GetAllDepartments())
            {
                cbxDepartment.Items.Add(department.Name);
            }

            // set navbar buttons visibility
            if (currentEmp.Position == "administrator")
            {
                btnEmployee.Visible = true;
                btnDepot.Visible = true;
                
            }
            else if (currentEmp.Position == "manager")
            {
                btnEmployee.Visible = true;
                btnDepot.Visible = false;
                
            }
            else if (currentEmp.Position == "shopworker")
            {
                btnEmployee.Visible = false;
                btnDepot.Visible = true;
                
            }
            else
            {
                btnEmployee.Visible = false;
                btnDepot.Visible = true;
                
            }
        }

        private void UpdateInfo()
        {
            manageEmp = EmployeeDatabase.GetEmployeeByID(manageId);

            lblName.Text = manageEmp.FirstName;
            lblSurname.Text = manageEmp.LastName;
            lblBirth.Text = manageEmp.DateOfBirth.ToString("dd-MM-yyyy");
            lblGender.Text = manageEmp.Gender;
            lblBSNNr.Text = manageEmp.Bsn;
            lblStartDate.Text = manageEmp.StartDate.ToString("dd-MM-yyyy");
            lblStreet.Text = manageEmp.Street;
            lblZipcode.Text = manageEmp.ZipCode;
            lblCity.Text = manageEmp.City;
            lblPosition.Text = manageEmp.Position;
            lblSalary.Text = "€" + manageEmp.Salary.ToString();
            lblEmail.Text = manageEmp.Email;
            lblPhoneNr.Text = manageEmp.PhoneNumber;
        }

        private void btnDeblock_Click_1(object sender, EventArgs e)
        {
            string username = manageEmp.LastName + manageEmp.FirstName;
            if (LoginDatabase.GetIsBlocked(username))
            {
                LoginDatabase.SetIsBlocked(username, false);
                MessageBox.Show("User unblocked succesfully");
            }
            else
            {
                MessageBox.Show("User was not blocked");
            }
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            // maybe with 'are you sure?' message box
            if (manageEmp.EndDate != null)
            {
                if (employeeController.ArchiveEmployee(currentID, DateTime.Now))
                {
                    MessageBox.Show("Employee is archived");
                }
                else
                {
                    MessageBox.Show("Something went wrong...");
                }
            }
            else
            {
                MessageBox.Show("This employee is already archived");
            }
        }

        private void btnChangePosition_Click(object sender, EventArgs e)
        {
            string position = Convert.ToString(cbxPosition.SelectedItem).ToLower();
            if (!employeeController.ChangePosition(position, manageId))
            {
                MessageBox.Show("You don't have permission");
            }
            else
            {
                MessageBox.Show("Position updated succesfully");
                UpdateInfo();
            }
        }

        private void btnChangeSalary_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxAmount.Text, @"^[0-9]*$"))
            {
                string salary = tbxAmount.TextName;
                employeeController.ChangeSalary(manageId, Convert.ToDouble(tbxAmount.TextName)); // make this a numeric up down??
                MessageBox.Show("Salary updated successfully");
                UpdateInfo();
            }
            else
            {
                MessageBox.Show("Please enter a valid salary");
            }
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            if (cbxPerc.SelectedItem != null)
            {
                double salary = Convert.ToDouble(cbxPerc.SelectedItem);
                employeeController.Raise(manageId, salary, manageEmp.Salary);
                MessageBox.Show("Salary successfully raised.");
                UpdateInfo();
            }
            else
            {
                MessageBox.Show("You need to select the percentage first");
            }
        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(cbxDepartment.SelectedItem);
            Department department = departmentController.GetDepartmentByName(name);
            if (!departmentController.AssignEmployeeToDep(manageEmp, department))
            {
                MessageBox.Show("You don't have permission");
            }
            else
            {
                MessageBox.Show("Department updated succesfully");
                UpdateInfo();
            }
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            IndividualSchedule individualSchedule = new IndividualSchedule(manageId);
            individualSchedule.Show();
        }

        //---------------- for nav bar
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(currentID);
            this.Close();
            dashboard.Show();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(currentID);
            this.Close();
            profile.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ViewEmployee viewEmployee = new ViewEmployee(currentID);
            this.Close();
            viewEmployee.Show();
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            Depot depot = new Depot(currentID);
            this.Close();
            depot.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
