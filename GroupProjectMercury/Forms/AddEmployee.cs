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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace GroupProjectMercury.Forms
{
    public partial class AddEmployee : Form
    {
        private EmployeeManagement employeeManagement;
        private EmployeeController employeeController;
        private int currentID;
        private Employee currentEmp;
        private Encryption encryption;

        public AddEmployee(int id)
        {
            InitializeComponent();
            currentID = id;
            employeeController = new EmployeeController(currentID);
            employeeManagement = new EmployeeManagement();
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentID);
            encryption = new Encryption();

            // fill comboboxes
            cbxPosition.Items.Clear();
            cbxPosition.Items.Add("shopworker");
            cbxPosition.Items.Add("depotWorker");
            cbxPosition.Items.Add("administrator");
            cbxPosition.Items.Add("manager");

            cbxGender.Items.Clear();
            cbxGender.Items.Add("male");
            cbxGender.Items.Add("female");
            cbxGender.Items.Add("other");

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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // maybe extend with regex and specific error handling
            if (Regex.IsMatch(tbxName.TextName, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("Invalid Name provided ! ! !");
            }
            else if (Regex.IsMatch(tbxSurname.TextName, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("Invalid Surname provided ! ! !");
            }
            else if (Regex.IsMatch(tbxBSNNr.TextName, @"^[0-9]{9}$") == false)
            {
                MessageBox.Show("Invalid BSN Number provided ! ! !");
            }
            else if (Regex.IsMatch(tbxEmail.TextName, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$") == false)
            {
                MessageBox.Show("Invalid Email provided ! ! !");
            }
            else if (Regex.IsMatch(tbxPhoneNr.TextName, @"^[0-9]{11,14}$") == false)
            {
                MessageBox.Show("Invalid Phone Number provided ! ! !");
            }
            else if (Regex.IsMatch(tbxStreet.TextName, @"\A(.*?)\s+(\d+[a-zA-Z]{0,1}\s{0,1}[-]{1}\s{0,1}\d*[a-zA-Z]{0,1}|\d+[a-zA-Z-]{0,1}\d*[a-zA-Z]{0,1})$") == false)
            {
                MessageBox.Show("Invalid Address provided ! ! !");
            }
            else if (Regex.IsMatch(tbxZipcode.TextName, @"^[0-9]{4}[A-Z]{2}$") == false)
            {
                MessageBox.Show("Invalid Zipcode provided ! ! !");
            }
            else if (Regex.IsMatch(tbxCity.TextName, @"^(?:[A-Z][a-z.-]+[ ]?)+$") == false)
            {
                MessageBox.Show("Invalid City provided ! ! !");
            }
            else
            {
                Employee employee;

                string firstname = tbxName.TextName.ToLower();
                string lastname = tbxSurname.TextName.ToLower();
                string username = firstname + "." + lastname;
                string password = encryption.Encrypt(employeeController.CreateTemporaryPassword(18).ToLower());
                DateTime birthdate = dtpDateOfBirth.Value;
                string gender = cbxGender.SelectedItem.ToString().ToLower();
                string street = tbxStreet.TextName.ToLower();
                string zipcode = tbxZipcode.TextName.ToLower();
                string city = tbxCity.TextName.ToLower();
                string phonenumber = tbxPhoneNr.TextName.ToLower();
                string email = tbxEmail.TextName.ToLower();
                DateTime startdate = DateTime.Now;
                string position = cbxPosition.SelectedItem.ToString().ToLower();
                double salary = Convert.ToDouble(nudSalary.Value);
                string bsn = tbxBSNNr.TextName.ToLower();

                if (cbxPosition.SelectedIndex == 0) // shopworker
                {
                    employee = new ShopWorker(firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                    if (employeeController.AddEmployee(employee))
                    {
                        EmployeeDatabase.AddNewEmployee(RemoveWhiteSpaces(username), password, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                        employeeManagement.AddEmployee(employee);
                        MessageBox.Show("Succesfully added");
                    }
                    else
                    {
                        MessageBox.Show("You dont have permission");
                    }
                }
                else if (cbxPosition.SelectedIndex == 1) // depotworker
                {
                    employee = new DepotWorker(firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);

                    if (employeeController.AddEmployee(employee))
                    {
                        EmployeeDatabase.AddNewEmployee(RemoveWhiteSpaces(username), password, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                        employeeManagement.AddEmployee(employee);
                        MessageBox.Show("Succesfully added");
                    }
                    else
                    {
                        MessageBox.Show("You dont have permission");
                    }
                }
                else if (cbxPosition.SelectedIndex == 2) // administrator
                {
                    employee = new Administrator(firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);

                    if (employeeController.AddEmployee(employee))
                    {
                        EmployeeDatabase.AddNewEmployee(RemoveWhiteSpaces(username), password, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                        employeeManagement.AddEmployee(employee);
                        MessageBox.Show("Succesfully added");
                    }
                    else
                    {
                        MessageBox.Show("You dont have permission");
                    }
                }
                else if (cbxPosition.SelectedIndex == 3) // manager
                {
                    employee = new Manager(firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);

                    if (employeeController.AddEmployee(employee))
                    {
                        EmployeeDatabase.AddNewEmployee(RemoveWhiteSpaces(username), password, firstname, lastname, birthdate, gender, street, zipcode, city, phonenumber, email, startdate, position, salary, bsn);
                        employeeManagement.AddEmployee(employee);
                        MessageBox.Show("Succesfully added");
                    }
                    else
                    {
                        MessageBox.Show("You dont have permission");
                    }
                }
            }
        }

        public string RemoveWhiteSpaces(string str)
        {
            str = str.Replace(" ", String.Empty);
            return str;
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(currentID);
            dashboard.Show();
            this.Close();
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            Depot depot = new Depot(currentID);
            depot.Show();
            this.Close();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
