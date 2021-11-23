using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GroupProjectMercury.Forms;

namespace MercuryUnitTestProject
{
    [TestClass]
    public class UnitTestDepartmentController
    {
        // getting all departments from database
        [TestMethod]
        public void GetAllDepartmentsTestMethod()
        {
            DepartmentController deptController = new DepartmentController(1);
            Assert.AreEqual(8, deptController.GetAllDepartments().Count);
        }


        // getting a non-existing department based on id from database
        [TestMethod]
        public void GetNonExistingDepartmentByIdTestMethod()
        {
            DepartmentController deptController = new DepartmentController(1);            
            Assert.AreEqual(null, deptController.GetDepartmentById(30));
        }


        // getting an existing department based on id from database
        [TestMethod]
        public void GetExistingDepartmentByIdTestMethod()
        {
            DepartmentController deptController = new DepartmentController(1);
            Assert.AreEqual(null, deptController.GetDepartmentById(30));
        }


        // getting a non-existing department based on name from database
        [TestMethod]
        public void GetNonExistingDepartmentByNameTestMethod()
        {
            DepartmentController deptController = new DepartmentController(1);
            Assert.AreEqual(null, deptController.GetDepartmentByName("Asdfgbn"));
        }


        // getting a existing department based on name from database
        [TestMethod]
        public void GetExistingDepartmentByNameTestMethod()
        {
            DepartmentController deptController = new DepartmentController(1);
            Assert.AreEqual(null, deptController.GetDepartmentByName(""));
        }


        //assigning an employee to a department
        [TestMethod]
        public void AssigningAnEmplToDepartTestMethod()
        {
            DepartmentController deptController = new DepartmentController(1);            
            Department d = deptController.GetDepartmentById(4);
            Employee e = EmployeeDatabase.GetEmployeeByID(3);
            Assert.AreEqual(true, deptController.AssignEmployeeToDep(e,d));
        }

    }
}
