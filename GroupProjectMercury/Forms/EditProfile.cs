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
    public partial class EditProfile : Form
    {
        private EmployeeController employeeController;
        private int currentID;
        private Employee emp;

        public EditProfile(int id)
        {
            InitializeComponent();
            currentID = id;
            employeeController = new EmployeeController(currentID);

            // display information of the logged in employee
            emp = EmployeeDatabase.GetEmployeeByID(currentID);
            FillInInfo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string street = tbxStreet.TextName;
            string zipcode = tbxZipcode.TextName;
            string city = tbxCity.TextName;
            string phone = tbxPhone.TextName;

            employeeController.EditProfile(street, zipcode, city, phone, currentID);

            MessageBox.Show("Profile successfully updated !");

            Profile profile = new Profile(currentID);
            profile.Show();
            this.Close();
        }

        private void FillInInfo()
        {
            lbPosition.Text = emp.Position;
            lbName.Text = emp.FirstName;
            lbSurname.Text = emp.LastName;
            lbBirth.Text = emp.DateOfBirth.ToString("dd-MM-yyyy"); // TODO: remove time from datetime object
            lbGender.Text = emp.Gender;
            lbBSNNr.Text = emp.Bsn;
            lblStartDate.Text = emp.StartDate.ToString("dd-MM-yyyy");
            tbxStreet.TextName = emp.Street;
            tbxZipcode.TextName = emp.ZipCode;
            tbxCity.TextName = emp.City;
            lblSalary.Text = "€" + emp.Salary.ToString();
            lbEmail.Text = emp.Email;
            tbxPhone.TextName = emp.PhoneNumber;
        }

        //---------------- for nav bar
        private void pbxBack_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(currentID);
            profile.Show();
            this.Close();
        }
    }
}
