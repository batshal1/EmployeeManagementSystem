using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectMercury.Forms
{
    public class DepartmentController
    {
        private int currentId;
        private Employee currentEmp;
        private Permissions permissions;


        private List<Department> departments;

        public DepartmentController(int id)
        {
            currentId = id;
            currentEmp = EmployeeDatabase.GetEmployeeByID(currentId);
            departments = DepartmentDatabase.GetAllDepartmentsFromDB();
            permissions = new Permissions(currentEmp);
        }

       
        public List<Department> GetAllDepartments()
        {
            if (permissions.GetPermission(Util.VIEW_DEPARTMENTS))
            {
                departments = DepartmentDatabase.GetAllDepartmentsFromDB();
                return departments;
            }
            else
            {
                return null;
            }
           
        }

        public Department GetDepartmentById(int id)
        {
            if (permissions.GetPermission(Util.VIEW_DEPARTMENTS))
            {
                foreach (Department d in departments)
                {
                    if (d.Id == id)
                    {
                        return d;
                    }
                }

                return null;
            }

            return null;
        }

        public Department GetDepartmentByName(string name)
        {
            if (permissions.GetPermission(Util.VIEW_DEPARTMENTS))
            {
                foreach (Department d in departments)
                {
                    if (d.Name == name)
                    {
                        return d;
                    }
                }
                return null;
            }

            return null;
        }
         

        public bool AssignEmployeeToDep(Employee e, Department d)
        {
            if (permissions.GetPermission(Util.MANAGE_DEPARTMENTS))
            {
                GetDepartmentById(d.Id).AddEmployee(e);
                DepartmentDatabase.AssignEmplToDepartToDB(d.Id, e.Id);
                return true;
            }
            else
            {
                return false;
            }
        }

         
    }
}
