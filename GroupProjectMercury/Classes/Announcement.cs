using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury
{
    public class Announcement
    {
        public string text { get; set; }
        public DateTime date { get; set; }
        public DateTime enddate { get; set; }
        public string title { get; set; }


        public Announcement(DateTime date, string text, string title, DateTime enddate)
        {
            this.date = date;
            this.text = text;
            this.title = title;
            this.enddate = enddate;
        }


        public override string ToString()
        {
            return "On " + date.ToString("d/M/yyyy") + " - " + title;
        }

    }
}
