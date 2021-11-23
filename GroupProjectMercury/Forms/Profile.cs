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
    public partial class Profile : Form
    {
        private Controller controller;
        private int currentID;
        private Employee currentEmp;
        private Encryption encryption;

        public Profile(int id)
        {
            InitializeComponent();
            currentID = id;
            controller = new Controller(currentID);
            encryption = new Encryption();

            // display information of the logged in employee
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentID);

            lblPosition.Text = currentEmp.Position;
            lblName.Text = currentEmp.FirstName;
            lblSurname.Text = currentEmp.LastName;
            lblBirth.Text = currentEmp.DateOfBirth.ToString("dd-MM-yyyy");
            lblGender.Text = currentEmp.Gender;
            lblBSNNr.Text = currentEmp.Bsn;
            lblStartDate.Text = currentEmp.StartDate.ToString("dd-MM-yyyy");
            lblStreet.Text = currentEmp.Street;
            lblZipcode.Text = currentEmp.ZipCode;
            lblCity.Text = currentEmp.City;
            lblSalary.Text = "€" + currentEmp.Salary.ToString();
            lblEmail.Text = currentEmp.Email;
            lblPhoneNr.Text = currentEmp.PhoneNumber;
            lblUsername.Text = (currentEmp.LastName + currentEmp.FirstName).ToLower();

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

        private void btnEditProfile_Click_1(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(currentID);
            editProfile.Show();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (controller.ChangeOwnPassword(encryption.Encrypt(tbxOldPassword.TextName), encryption.Encrypt(tbxNewPassword.TextName)))
            {
                MessageBox.Show("Password updated succesfully");

                tbxNewPassword.TextName = "";
                tbxOldPassword.TextName = "";
            }
            else
            {
                MessageBox.Show("Please enter correct input in the fields");
            }
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

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(currentID);
            dashboard.Show();
            this.Close();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            // thats this form
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ViewEmployee viewEmployee = new ViewEmployee(currentID);
            viewEmployee.Show();
            this.Close();
        }

        private void btnDepot_Click_1(object sender, EventArgs e)
        {
            Depot depot = new Depot(currentID);
            depot.Show();
            this.Close();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
