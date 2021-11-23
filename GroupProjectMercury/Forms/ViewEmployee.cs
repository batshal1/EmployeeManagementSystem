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
    public partial class ViewEmployee : Form
    {
        private EmployeeController employeeController;
        private int currentID;
        private Employee currentEmp;

        public ViewEmployee(int id)
        {
            InitializeComponent();
            currentID = id;
            employeeController = new EmployeeController(currentID);
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentID);

            // Display all employees in the DataGridView
            dgvEmployees.DataSource = employeeController.GetAllEmployees();
            dgvEmployees.Columns["enddate"].Visible = false;
            // properties: SelectionMode -> fullRowSelected

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

            // check checkboxes
            cbId.Checked = true;
            cbFirstname.Checked = true;
            cbLastname.Checked = true;
            cbBirthdate.Checked = true;
            cbGender.Checked = true;
            cbStreet.Checked = true;
            cbZipcode.Checked = true;
            cbCity.Checked = true;
            cbPhonenr.Checked = true;
            cbEmail.Checked = true;
            cbStartdate.Checked = true;
            cbPosition.Checked = true;
            cbSalary.Checked = true;
            cbBSN.Checked = true;
            cbDepartment.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Employee> tempEmployees = new List<Employee>();

            if (tbxSearch.Text == "")
            {
                MessageBox.Show("Please enter a text to search");
            }
            else
            {
                tempEmployees = employeeController.SearchEmployees(tbxSearch.Text);
                dgvEmployees.DataSource = tempEmployees;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = employeeController.GetAllEmployees();
        }

        private void btnViewArchivedEmp_Click(object sender, EventArgs e)
        {
            // Display all archived employees in the DataGridView
            dgvEmployees.DataSource = employeeController.GetArchivedEmployees();
        }

        //---------------- for nav bar
        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(currentID);
            dashboard.Show();
            this.Close();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(currentID);
            profile.Show();
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(currentID);
            addEmployee.Show();
            this.Close();
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            Depot depot = new Depot(currentID);
            depot.Show();
            this.Close();
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            Employee selectedEmployee = dgvEmployees.SelectedRows[0].DataBoundItem as Employee;
            // dgvEmployees.CurrentCell.RowIndex            
                ManagingEmployee management = new ManagingEmployee(currentID, selectedEmployee.Id);
                management.Show();
                this.Close();
           
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics(currentID);
            statistics.Show();
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ViewEmployee viewEmployee = new ViewEmployee(currentID);
            viewEmployee.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        // check checkboxes for datagridview data
        private void cbId_CheckedChanged(object sender, EventArgs e)
        {
            if (cbId.Checked)
            {
                dgvEmployees.Columns["id"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["id"].Visible = false;
            }
        }

        private void cbFirstname_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFirstname.Checked)
            {
                dgvEmployees.Columns["firstname"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["firstname"].Visible = false;
            }
        }

        private void cbLastname_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLastname.Checked)
            {
                dgvEmployees.Columns["lastname"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["lastname"].Visible = false;
            }
        }

        private void cbBirthdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBirthdate.Checked)
            {
                dgvEmployees.Columns["dateofbirth"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["dateofbirth"].Visible = false;
            }
        }

        private void cbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGender.Checked)
            {
                dgvEmployees.Columns["gender"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["gender"].Visible = false;
            }
        }

        private void cbStreet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStreet.Checked)
            {
                dgvEmployees.Columns["street"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["street"].Visible = false;
            }
        }

        private void cbZipcode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbZipcode.Checked)
            {
                dgvEmployees.Columns["zipcode"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["zipcode"].Visible = false;
            }
        }

        private void cbCity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCity.Checked)
            {
                dgvEmployees.Columns["city"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["city"].Visible = false;
            }
        }

        private void cbPhonenr_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPhonenr.Checked)
            {
                dgvEmployees.Columns["phonenumber"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["phonenumber"].Visible = false;
            }
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmail.Checked)
            {
                dgvEmployees.Columns["email"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["email"].Visible = false;
            }
        }

        private void cbStartdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStartdate.Checked)
            {
                dgvEmployees.Columns["startdate"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["startdate"].Visible = false;
            }
        }

        private void cbPosition_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPosition.Checked)
            {
                dgvEmployees.Columns["position"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["position"].Visible = false;
            }
        }

        private void cbSalary_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSalary.Checked)
            {
                dgvEmployees.Columns["salary"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["salary"].Visible = false;
            }
        }

        private void cbBSN_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBSN.Checked)
            {
                dgvEmployees.Columns["bsn"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["bsn"].Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDepartment.Checked)
            {
                dgvEmployees.Columns["deptid"].Visible = true;
            }
            else
            {
                dgvEmployees.Columns["deptid"].Visible = false;
            }
        }
    }
}
