using GroupProjectMercury.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury
{
    public class Announcer
    {
        public List<Announcement> announcements { get; }

        public Announcer()
        {
            announcements = AnnouncementDatabase.GetAnnouncements();
        }
        public void PostAnnouncement(Announcement announcement)
        {
            announcements.Add(announcement);
        }
    }
}
