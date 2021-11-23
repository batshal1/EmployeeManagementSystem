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
    public partial class AnnouncementDetails : Form
    {
        private Announcement selectedAnnouncement;

        public AnnouncementDetails(Announcement announcement)
        {
            InitializeComponent();
            selectedAnnouncement = announcement;
            FillInfo();
        }

        public void FillInfo()
        {
            lbTitle.Text = selectedAnnouncement.title;
            lbPublishDate.Text = Convert.ToString(selectedAnnouncement.date.ToString("d/M/yyyy"));
            lbEndDate.Text = Convert.ToString(selectedAnnouncement.enddate.ToString("d/M/yyyy"));
            tbxMessage.Text = selectedAnnouncement.text;
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
