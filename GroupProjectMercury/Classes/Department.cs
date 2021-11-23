using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class Department
    {
        public static int idSeeder = 1;

        private List<Employee> employees;
        public Department(string name)
        {
            this.Name = name;
            employees = new List<Employee>();
            this.Id = idSeeder++;
        }

        public Department(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            employees = DepartmentDatabase.GetEmployeesPerDepartment(Id);
            //this.Id = idSeeder++;
        }

        public string Name { get; set;}

        public int Id { get; set; }
         
         

        public void AddEmployee(Employee e)
        {
            employees.Add(e);
        }
         

        public override string ToString()
        {
            return "ID: " + this.Id + ", Department: " + this.Name;
        }
    }
}
