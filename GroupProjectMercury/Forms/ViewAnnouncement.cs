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
    public partial class ViewAnnouncement : Form
    {
        int currentID;
        private AnnouncementController announcementController;
        private Employee currentEmp;
        private List<Announcement> allAnnouncements;

        public ViewAnnouncement(int id)
        {
            InitializeComponent();
            this.currentID = id;
            announcementController = new AnnouncementController(currentID);
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentID);
            //List the announcements 
            ListAnnouncements();
            allAnnouncements = new List<Announcement>();

            if(currentEmp.Position == "administrator" || currentEmp.Position == "manager")
            {
                btnAddAnnouncement.Visible = true;
                btnEdit.Visible = true;
            }
            else
            {
                btnAddAnnouncement.Visible = false;
                btnEdit.Visible = false;
            }
        }

        private void btnAddAnnouncement_Click(object sender, EventArgs e)
        {
            AddAnnouncement addAnnouncement = new AddAnnouncement(currentID);
            addAnnouncement.Show();
            this.Close();
        }

        public void ListAnnouncements()
        {
            lbxAnnouncements.Items.Clear();
            List<Announcement> announcements = announcementController.GetAnnouncements();

            if (announcements.Count < 1)
            {
                lbxAnnouncements.Items.Add("There are no current announcements");
            }
            else
            {
                announcements.Sort();
                
                for (int i = 0; i < announcements.Count; i++)
                {
                    if (DateTime.Compare(announcements[i].enddate, DateTime.Now.Date) >= 0)
                    {
                        lbxAnnouncements.Items.Add( announcements[i].ToString() );
                    }
                }
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (lbxAnnouncements.SelectedItem != null)
            {
                Announcement announcement = announcementController.GetAnnouncement(Convert.ToString(lbxAnnouncements.SelectedItem));
                EditAnnouncement editAnnouncement = new EditAnnouncement(currentID, announcement);
                editAnnouncement.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Select an announcement! ! !");
            }
        }

        private void lbxAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            Announcement announcement = announcementController.GetAnnouncement(Convert.ToString(lbxAnnouncements.SelectedItem));
            AnnouncementDetails announcementDetails = new AnnouncementDetails(announcement);
            announcementDetails.Show();            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
