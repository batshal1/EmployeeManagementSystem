using GroupProjectMercury.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectMercury
{
    public partial class AddAnnouncement : Form
    {
        private AnnouncementController announcementController;
        private int currentID;

        public AddAnnouncement(int id)
        {
            InitializeComponent();
            announcementController = new AnnouncementController(id);
            currentID = id;
        }

        private void btnAddAnnouncement_Click(object sender, EventArgs e)
        {
            if ((tbxMessage.Text == "") && (tbxTitle.Text == ""))
            {
                MessageBox.Show("There is no announcement to be added!");
            }
            else
            {
                // make announcement and add to database
                Announcement announcement = new Announcement(DateTime.Now, tbxMessage.Text, tbxTitle.Text, monthCalendar.SelectionRange.Start.Date);
                if (announcementController.PostAnnouncement(announcement))
                {
                    MessageBox.Show("Announcement added succesfully");
                    // add announcement to the form for overview
                    ViewAnnouncement viewAnnouncement = new ViewAnnouncement(currentID);
                    viewAnnouncement.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong... / You dont have permission");
                }
            }
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
