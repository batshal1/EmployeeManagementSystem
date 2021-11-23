using GroupProjectMercury.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury
{
    public class ShiftManagement
    {
        private List<Shift> shifts;

        public ShiftManagement()
        {
            shifts = ScheduleDatabase.GetAllShifts();
        }

        public void AddShift(Shift shift)
        {
            shifts.Add(shift);
        }

        public void RemoveShift(Shift shift)
        {
            ScheduleDatabase.RemoveShift(shift);
            shifts.Remove(shift);
        }

        
    }
}
