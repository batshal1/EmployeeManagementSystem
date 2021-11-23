using GroupProjectMercury.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury
{
    public class EmployeeStatistics: IStatistics
    {
        private List<Employee> employees;
        public EmployeeStatistics(List<Employee> emp)
        {
            employees = emp;
            
        }

        public double CalcAverage()
        {
            if(employees.Count > 0)
            {
                double empNr = employees.Count;
                double totalSal = 0;
                foreach (Employee item in employees)
                {
                    totalSal = totalSal + item.Salary;
                }
                
                double result = totalSal / empNr;
                return result;
                
            }
            else
            {
                
                return 0;
            }
            

            
        }


        public int GetNrPerType(string type)
        {
            int result = 0; 
            foreach (Employee item in employees)
            {
                if(Convert.ToString(item.GetType()) == type)
                {
                    result++;
                }
                
            }
            
            return result;
        }

        public int TotalNumber()
        {
            return employees.Count;
        }


        public int GetNrPerGender(string gender)
        {
            int nr = 0; 
            foreach (Employee item in employees)
            {
                if(item.Gender == gender)
                {
                    nr++;
                }
            }

            return nr;
        }


        public int GetNrPerAge(int year1, int year2)
        {
            int nr = 0;
            foreach (Employee item in employees)
            {
                if((item.DateOfBirth.Year >= year1) && (item.DateOfBirth.Year < year2))
                {
                    nr ++;
                }
            }
            return nr;
        }
    }
}
