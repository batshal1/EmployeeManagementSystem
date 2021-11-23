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

namespace GroupProjectMercury.Forms
{
    public partial class Login : Form
    {
        private Dashboard dashboard;
        private IDictionary<string, int> userAttempts;
        private Encryption encryption; 

        public Login()
        {
            InitializeComponent();
            userAttempts = new Dictionary<string, int>();
            encryption = new Encryption();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbxUserName.TextName;
            string password = encryption.Encrypt(tbxPassword.TextName);

            // if username does exist:
            // if user is blocked then show message
            // else if user credentials are correct then log in
            // else if user credentials are incorrect then attemps++ and try again message and update isblocked in database
            // else if user doesnt exist

            if (LoginDatabase.GetUsernameExists(username))
            {
                if (LoginDatabase.GetIsBlocked(username))
                {
                    MessageBox.Show("You are blocked from the system. Please contact the administrator.");
                }
                else if (LoginDatabase.UserLookup(username, password))
                {
                    int empid = EmployeeDatabase.GetIdOfEmployee(username, password);
                    string position = EmployeeDatabase.GetPositionFromID(empid);
                    dashboard = new Dashboard(empid);
                    Hide();
                    dashboard.Show();
                }
                else
                {
                    if (userAttempts.ContainsKey(username))
                    {
                        userAttempts[username]++;
                    }
                    else
                    {
                        userAttempts.Add(username, 1);
                    }

                    if (userAttempts[username] >= 3)
                    {
                        LoginDatabase.SetIsBlocked(username, true);
                        MessageBox.Show("You have tried to log in three times! You are blocked from the system. Please contact the administrator");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password"); // you have not been blocked
                    }
                }
            }
            else //User doesnt exist
            {
                MessageBox.Show("This username does not exist");
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

        //------------------- for designing
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse
        );

        private void Login_Load(object sender, EventArgs e)
        {
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 10, 10));
        }
    }
}
