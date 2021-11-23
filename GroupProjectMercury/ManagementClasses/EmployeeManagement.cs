using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class EmployeeManagement
    {
        private List<Employee> employees = new List<Employee>();

        public EmployeeManagement()
        {
            employees = EmployeeDatabase.GetAllEmployees();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

    }
}
