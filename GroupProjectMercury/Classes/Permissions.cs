using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectMercury.Forms
{
    public class Permissions
    {
        // employees
        private bool addEmployee = false;
        private bool removeEmployee = false;
        private bool searchEmployee = false;
        private bool viewEmployee = false;
        private bool viewAllEmployees = false;
        private bool changePosition = false;
        private bool changeSalary = false;
        private bool archive = false;

        // shifts
        private bool assignShift = false;
        private bool viewShifts = false;

        // products
        private bool viewProducts = false;
        private bool viewRestockRequest = false;
        private bool addProduct = false;
        private bool removeProduct = false;
        private bool restockProduct = false;
        private bool searchProducts = false;
        private bool getProducts = false;

        // statistics
        private bool viewStatistics = false;

        // announcements
        private bool addAnnouncement = false;

        // offdays
        private bool addOffday = false;

        //departments
        private bool viewDepartments = false;
        private bool manageDepartments = false;


        // reset all permissions to false
        public void ResetPermissions()
        {
            // employees
            addEmployee = false;
            removeEmployee = false;
            searchEmployee = false;
            viewEmployee = false;
            viewAllEmployees = false;
            changePosition = false;
            changeSalary = false;
            archive = false;

            // products
            viewProducts = false;
            viewRestockRequest = false;
            addProduct = false;
            removeProduct = false;
            restockProduct = false;
            searchProducts = false;
            getProducts = false;

            // shifts
            assignShift = false;
            viewShifts = false;

            // statistics
            viewStatistics = false;

            // offdays
            addOffday = false;

            // announcements
            addAnnouncement = false;

            //departments
            viewDepartments = false;
            manageDepartments = false;
    }

        public bool GetPermission(int task)
        {
            if (task == Util.ADD_EMPLOYEE)
            {
                return addEmployee;
            } 
            else if (task == Util.REMOVE_EMPLOYEE)
            {
                return removeEmployee;
            } 
            else if (task == Util.ASSIGN_SHIFT)
            {
                return assignShift;
            }
            else if (task == Util.SEARCH_EMPLOYEE)
            {
                return searchEmployee;
            }
            else if (task == Util.VIEW_EMPLOYEE)
            {
                return viewEmployee;
            }
            else if (task == Util.VIEW_SHIFTS)
            {
                return viewShifts;
            }
            else if (task == Util.VIEW_DATASTOCK)
            {
                return viewProducts;
            }
            else if (task == Util.VIEW_RESTOCKREQUEST)
            {
                return viewRestockRequest;
            }
            else if (task == Util.VIEW_STATISTICS)
            {
                return viewStatistics;
            }
            else if (task == Util.ADD_PRODUCT)
            {
                return addProduct;
            }
            else if (task == Util.REMOVE_PRODUCT)
            {
                return removeProduct;
            } 
            else if (task == Util.RESTOCK_PRODUCT)
            {
                return restockProduct;
            }
            else if (task == Util.VIEW_ALL_EMPLOYEES)
            {
                return viewAllEmployees;
            }
            else if (task == Util.SEARCH_EMPLOYEE)
            {
                return searchEmployee;
            }
            else if (task == Util.CHANGE_POSITION)
            {
                return changePosition;
            }
            else if (task == Util.CHANGE_SALARY)
            {
                return changeSalary;
            }
            else if (task == Util.ARCHIVE)
            {
                return archive;
            }
            else if (task == Util.SEARCH_PRODUCTS)
            {
                return searchProducts;
            }
            else if (task == Util.GET_PRODUCTS)
            {
                return getProducts;
            }
            else if (task == Util.POST_ANNOUNCEMENT)
            {
                return addAnnouncement;
            }
            else if (task == Util.ADD_OFFDAY)
            {
                return addOffday;
            }
            else if(task == Util.VIEW_DEPARTMENTS)
            {
                return viewDepartments;
            }  
            else if(task == Util.MANAGE_DEPARTMENTS)
            {
                return manageDepartments;
            }
            // and so on...
            else
            {
                return false;
            }
        }

        public void SetPermissionsForShopWorker(string position)
        {
            if (position == "shopworker")
            {
                // products
                removeProduct = true;
                getProducts = true;
                searchProducts = true;
                restockProduct = true;
            }
        }

        public void SetPermissionsForDepotWorker(string position)
        {
            if (position == "depotworker")
            {
                // products
                viewProducts = true;
                viewRestockRequest = true;
                addProduct = true;
                removeProduct = true;
                restockProduct = true;
                searchProducts = true;
                getProducts = true;
            }
        }

        public void SetPermissionsForAdministrator(string position)
        {
            if (position == "administrator")
            {
                // employees
                addEmployee = true;
                removeEmployee = true;
                searchEmployee = true;
                viewAllEmployees = true;
                viewEmployee = true;
                changePosition = true;
                changeSalary = true;
                archive = true;

                // products
                getProducts = true;
                removeProduct = true;
                restockProduct = true;
                searchProducts = true;

                // announcements
                addAnnouncement = true;

                // shifts
                assignShift = true;
                viewShifts = true;

                // offdays
                addOffday = true;

                //departments
                viewDepartments = true;
                manageDepartments = true;
            }
        }

        public void SetPermissionsForManager(string position)
        {
            if (position == "manager")
            {
                // employees
                searchEmployee = true;
                viewAllEmployees = true;
                viewEmployee = true;

                // shifts
                viewShifts = true;

                // statistics
                viewStatistics = true;

                //departments
                viewDepartments = true;
            }
        }

        public Permissions(Employee employee)
        {
            if(employee.Position == "administrator")
            {
                SetPermissionsForAdministrator(employee.Position);
            }

            if(employee.Position == "manager")
            {
                SetPermissionsForManager(employee.Position);
            }

            if(employee.Position == "depotworker")
            {
                SetPermissionsForDepotWorker(employee.Position);
            }

            if(employee.Position == "shopworker")
            {
                SetPermissionsForShopWorker(employee.Position);
            }

        }

        public Permissions()
        {

        }
    }
}
