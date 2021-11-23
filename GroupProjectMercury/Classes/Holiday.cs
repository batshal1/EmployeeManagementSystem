using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
   public class Holiday
   {
        private List<DateTime> holidays;

        public Holiday()
        {
            holidays = new List<DateTime>();
            holidays.Add(Convert.ToDateTime("24/12/2020"));
            holidays.Add(Convert.ToDateTime("25/12/2020"));
            holidays.Add(Convert.ToDateTime("26/12/2020"));
            holidays.Add(Convert.ToDateTime("31/12/2020"));
            holidays.Add(Convert.ToDateTime("01/01/2021"));
            holidays.Add(Convert.ToDateTime("27/04/2021"));
            holidays.Add(Convert.ToDateTime("04/04/2021"));
            holidays.Add(Convert.ToDateTime("05/04/2021"));
            holidays.Add(Convert.ToDateTime("13/05/2021"));
            holidays.Add(Convert.ToDateTime("23/05/2021"));
            holidays.Add(Convert.ToDateTime("24/05/2021"));
            holidays.Add(Convert.ToDateTime("25/12/2021"));
            holidays.Add(Convert.ToDateTime("26/12/2021"));            
        }

        public List<DateTime> GetHolidays()
        {
            return holidays;
        }
   }
}
