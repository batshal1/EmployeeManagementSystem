using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class Shift
    {
        public int EmpId { get; set; }
        public DateTime Date { get; set; }
        public string TimeOfDay { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Shift(int id, DateTime date, TimeSpan starttime, TimeSpan endtime, string timeofday) // check what time of day and set the fields directly to the right timing
        {
            EmpId = id;
            this.Date = date;
            this.StartTime = date + starttime;
            this.EndTime = date + endtime;
            this.TimeOfDay = timeofday;
        }

        public override string ToString()
        {
            return $"{EmpId} has a {TimeOfDay} shift at {Date.ToString("dd-MM-yyyy")}";
        }
    }
}
