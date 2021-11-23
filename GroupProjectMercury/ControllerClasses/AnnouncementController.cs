using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class AnnouncementController
    {
        private int currentId;
        private Employee currentEmp;
        private Permissions permissions;
        private Announcer announcer;

        public AnnouncementController(int id)
        {
            currentId = id;
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentId);
            permissions = new Permissions(currentEmp);            
            announcer = new Announcer();
        }

        // announcements
        public bool PostAnnouncement(Announcement announcement)
        {
            if (permissions.GetPermission(Util.POST_ANNOUNCEMENT))
            {
                AnnouncementDatabase.PostAnnouncement(announcement);
                announcer.PostAnnouncement(announcement);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Announcement> GetAnnouncements()
        {
            // no permission needed: everyone is allowed to view announcements in the Dashboard
            return announcer.announcements;
        }

        public Announcement GetAnnouncement(string text)
        {
            foreach (Announcement item in announcer.announcements)
            {
                if (item.ToString() == text)
                {
                    return item;
                }
            }
            return null;
        }

        public void EditAnnouncement(DateTime date, string text, string title, DateTime enddate, string oldText)
        {
            AnnouncementDatabase.EditAnnouncement(date, text, title, enddate, oldText);

        }

    }
}
