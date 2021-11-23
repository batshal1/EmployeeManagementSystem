using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectMercury.Forms
{
    public class Controller
    {
        private int currentId;
        private Employee currentEmp;
        private EmployeeStatistics empStatistics; 
        private ShiftManagement shiftManagement;
        private Permissions permissions;
        private ScheduleController scheduleController;
        private EmployeeController employeeeController;

        public Controller(int id)
        {
            employeeeController = new EmployeeController(id); 
            shiftManagement = new ShiftManagement(); 
            permissions = new Permissions(); 
            currentId = id;
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentId);
            empStatistics = new EmployeeStatistics(EmployeeDatabase.GetAllEmployees());
            scheduleController = new ScheduleController(id);

            // set permissions
            permissions.ResetPermissions();

            if (currentEmp.Position == "shopworker")
            {
                permissions.SetPermissionsForShopWorker(currentEmp.Position);
            }
            else if (currentEmp.Position == "depotworker")
            {
                permissions.SetPermissionsForDepotWorker(currentEmp.Position);
            }
            else if (currentEmp.Position == "administrator")
            {
                permissions.SetPermissionsForAdministrator(currentEmp.Position);
            }
            else if (currentEmp.Position == "manager")
            {
                permissions.SetPermissionsForManager(currentEmp.Position);
            }
            else
            {
                permissions.ResetPermissions();
            }
        }

        // user

        public bool ChangeOwnPassword(string oldPassword, string newPassword)
        {
            if (oldPassword == LoginDatabase.GetPasswordPerId(currentId)) // everyone is allowed to change their own password
            {
                LoginDatabase.UpdateEmployeePassword(newPassword, currentId);
                return true;
            }
            else
            {
                return false;
            }
        }


        // shifts

        public bool AssignShift(Shift shift)
        {
            if (permissions.GetPermission(Util.ASSIGN_SHIFT))
            {
                ScheduleDatabase.SetShift(shift);
                shiftManagement.AddShift(shift);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> GetEmployeesPerShiftPerDateAndTime(DateTime date, string timeofday)
        {
            if (permissions.GetPermission(Util.VIEW_SHIFTS))
            {
                return ScheduleDatabase.GetEmployeesOfShiftsPerDateAndTime(date, timeofday);
            }
            else
            {
                return new List<Employee>();
            }
        }


        // statistics
        public int GetTotalNrOfEmployees()
        {
            
            return empStatistics.TotalNumber();
        }

        public double GetAverageSalary()
        {
            
            return empStatistics.CalcAverage();
        }

        public int GetNrOfType(string type)
        {
            return empStatistics.GetNrPerType(type);
        }

        public int GetNrPerGender(string gender)
        {
            return empStatistics.GetNrPerGender(gender);
        }

        public int GetNrPerAge(int year1, int year2)
        {
            return empStatistics.GetNrPerAge(year1, year2);
        }


       
        //preferences

        public List<DateTime> GetPreferencesByEmployee(int id)
        {
            return ScheduleDatabase.GetPreferencesByEmployee(id);
        }

        public bool SendPreferences(int id, DateTime date)
        {
            if (ScheduleDatabase.SendPreferences(id, date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool CheckPrefDay(int id, DateTime date)
        {
            if(ScheduleDatabase.CheckPreferenceDay(id, date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Get mini Controllers
        public EmployeeController GetEmployeeController()
        {
            return employeeeController;
        }

        public ScheduleController GetScheduleController()
        {
            return scheduleController;
        }
    }
}
