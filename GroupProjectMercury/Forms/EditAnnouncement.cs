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
    public partial class EditAnnouncement : Form
    {
        private AnnouncementController announcementController;
        private int currentID;
        private Announcement selectedAnnouncement;

        public EditAnnouncement(int id, Announcement announcement)
        {
            InitializeComponent();
            announcementController = new AnnouncementController(id);
            currentID = id;
            selectedAnnouncement = announcement;
            AutomaticFill();
        }

        public void AutomaticFill()
        {
            txtbxTitle.Text = selectedAnnouncement.title;
            tbxMessage.Text = selectedAnnouncement.text;
            monthCalendar1.AddBoldedDate(selectedAnnouncement.enddate);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ((txtbxTitle.Text != "") && (tbxMessage.Text != null))
            {
                string title = txtbxTitle.Text;
                DateTime enddate = Convert.ToDateTime(monthCalendar1.SelectionRange.Start.Date);
                string text = tbxMessage.Text;

                announcementController.EditAnnouncement(DateTime.Now, text, title, enddate, selectedAnnouncement.text);

                MessageBox.Show("Announcement successfully updated !");

                ViewAnnouncement viewAnnouncement = new ViewAnnouncement(currentID);
                viewAnnouncement.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the spaces ! ! !");
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
