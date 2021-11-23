using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class EmployeeController
    {
        private int currentId;
        private Employee currentEmp;
        private EmployeeManagement employeeManagement;
        private Permissions permissions;

        public EmployeeController(int id)
        {
            currentId = id;
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentId);
            employeeManagement = new EmployeeManagement();
            permissions = new Permissions(currentEmp);
        }

        // employees
        public bool AddEmployee(Employee employee)
        {
            if (permissions.GetPermission(Util.ADD_EMPLOYEE))
            {
                employeeManagement.AddEmployee(employee);
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<Employee> GetAllEmployees()
        {
            if (permissions.GetPermission(Util.VIEW_ALL_EMPLOYEES))
            {
                return EmployeeDatabase.GetAllEmployees();
            }
            else
            {
                return new List<Employee>();
            }
        }

        public List<int> LoadIDs()
        {
            // maybe with permissions??
            return EmployeeDatabase.GetAllIds();
        }

        public bool ArchiveEmployee(int id, DateTime enddate)
        {
            if (permissions.GetPermission(Util.ARCHIVE))
            {
                EmployeeDatabase.Archive(id, enddate);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> GetArchivedEmployees()
        {
            return EmployeeDatabase.GetArchivedEmployees();
        }

        public void EditProfile(string street, string zipcode, string city, string phone, int id)
        {
            // no permission needed: everyone is allowed to edit their profile
            EmployeeDatabase.UpdateProfile(street, zipcode, city, phone, id);
        }

        public string CreateTemporaryPassword(int length)
        {
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789&é";
            Random random = new Random();
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }

        // employees: update
        public bool ChangePosition(string position, int id)
        {
            if (permissions.GetPermission(Util.CHANGE_POSITION))
            {
                EmployeeDatabase.UpdateEmployeePosition(position, id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ChangeSalary(int id, double salary)
        {
            //if (permissions.GetPermission(Util.CHANGE_SALARY))
            //{
            EmployeeDatabase.UpdateEmployeeSalary(id, salary);
            // return true;
            // }
            //else
            //{
            //  return false;
            //}
        }

        public void Raise(int id, double salary, double initial)
        {
            double raise = (salary * initial) / 100;
            double final = initial + raise;
            EmployeeDatabase.UpdateEmployeeSalary(id, final);
        }

        // employees: search
        public List<Employee> SearchEmployees(string text)
        {
            if (permissions.GetPermission(Util.SEARCH_EMPLOYEE))
            {
                return EmployeeDatabase.SearchEmployees(text);
            }
            else
            {
                return null;
            }
        }

        public Employee GetEmployeeByString(string text)
        {
            foreach (Employee e in GetAllEmployees())
            {
                string names = e.FirstName + " " + e.LastName;
                if(names == text)
                {
                    return e;
                }
            }

            return null;
        }

    }
}
