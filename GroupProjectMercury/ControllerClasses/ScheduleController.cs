using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class ScheduleController
    {
        private Holiday holiday;
        private int currentId;
        private PreferenceManagement prefManagement;
        private ShiftManagement shiftManagement;
        private List<int> availableEmployees;
        private Dictionary<int, int> countShifts = new Dictionary<int, int>();

        public ScheduleController(int empId)
        {
            holiday = new Holiday();
            this.currentId = empId;
            prefManagement = new PreferenceManagement();
            shiftManagement = new ShiftManagement();
            availableEmployees = EmployeeDatabase.GetAllIdsShopAndDepot();

            for (int i = 1; i <= availableEmployees.Count; i++)
            {
                countShifts[availableEmployees[i - 1]] = 0;
            }
        }

        public List<Shift> GenerateAutoSchedule()
        {
            List<Shift> generatedShifts = new List<Shift>();
            int countShiftPerDay = 0;
            int counter = 0;
            for (int i = 1; i <= GetAvailableWorkDays().Count; i++)
            {
                for (int j = 1; j <= availableEmployees.Count; j++)
                {
                    if ((!CheckIfDayIsPreferenceDayPerId(availableEmployees[j - 1], GetAvailableWorkDays()[i - 1])) && (countShiftPerDay < 15))
                    {
                        Shift shift;
                        if (counter < 5)
                        {
                            shift = new Shift(availableEmployees[j - 1], GetAvailableWorkDays()[i - 1], new TimeSpan(09, 00, 00), new TimeSpan(12, 00, 00), "morning");
                        }
                        else if (counter < 10)
                        {
                            shift = new Shift(availableEmployees[j - 1], GetAvailableWorkDays()[i - 1], new TimeSpan(12, 00, 00), new TimeSpan(16, 00, 00), "afternoon");
                        }
                        else
                        {
                            shift = new Shift(availableEmployees[j - 1], GetAvailableWorkDays()[i - 1], new TimeSpan(16, 00, 00), new TimeSpan(22, 00, 00), "evening");
                        }
                        generatedShifts.Add(shift);

                        counter++;
                        countShifts[availableEmployees[j - 1]]++;               
                        countShiftPerDay++;
                        ScheduleDatabase.SetShift(shift);
                    }
                }                

                RearrangeList();
                countShiftPerDay = 0;
                counter = 0;
            }

            //AddScheduleToDB(generatedShifts);
            return generatedShifts;
        }


        public void RearrangeList()
        {
            countShifts = countShifts.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public List<DateTime> GetAvailableWorkDays()
        {
            List<DateTime> days = new List<DateTime>();
            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.AddMonths(1).Month); i++)
            {
                string text = i + "/" + DateTime.Now.AddMonths(1).Month + "/" + DateTime.Now.Year;
                DateTime dt = Convert.ToDateTime(text);
                if (!CheckIfDayIsHoliday(dt))
                {
                    days.Add(dt);
                }
            }
            return days;
        }

        public bool CheckIfDayIsPreferenceDayPerId(int empid, DateTime day)
        {
            if (prefManagement.GetPreferencesPerId(empid).Contains(day))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfDayIsHoliday(DateTime day)
        {
            foreach (DateTime d in holiday.GetHolidays())
            {
                if((d.Day == day.Day) && (d.Month == day.Month))
                {
                    return true;
                }
            }

            return false;
        }


        public int GetCountOfShiftsPerDateAndTime(DateTime dt, string timeofday)
        {
            return ScheduleDatabase.GetCountOfShiftsPerDateAndTime(dt, timeofday);
        }

        public ShiftManagement GetShiftManagement()
        {
            return shiftManagement;
        }

    }
}
