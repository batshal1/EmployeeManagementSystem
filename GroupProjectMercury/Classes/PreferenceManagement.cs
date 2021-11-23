using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
   public  class PreferenceManagement
   {
        private Dictionary<int, List<DateTime>> preferences = new Dictionary<int, List<DateTime>>();
        private List<int> ids;
        private List<DateTime> dates;

        public PreferenceManagement()
        {
            // load all the ids from the database
           ids = EmployeeDatabase.GetAllIds();

            //load all the preferences from the database
            //dates = new List<DateTime>();

            //combine all the ids and the preferences in a dictionary

            for (int i = 1; i <= ids.Count; i++)
            {
                dates = ScheduleDatabase.GetPreferencesByEmployee(i);
                preferences.Add(i,dates);
            }
        }
         

        public List<DateTime> GetPreferencesPerId(int empid)
        {
            return preferences[empid];
        }
   }
}
