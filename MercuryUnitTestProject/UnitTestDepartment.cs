using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GroupProjectMercury.Forms;

namespace MercuryUnitTestProject
{
    [TestClass]
    public class UnitTestDepartment
    {
        [TestMethod]
        public void ConstructorWithoutIDTestMethod()
        {
            Department dept = new Department("Finances");
            Assert.AreEqual("Finances", dept.Name);
            Assert.AreEqual(1, dept.Id);
        }


        [TestMethod]
        public void ConstructorWithIDTestMethod()
        {
            Department dept = new Department(1,"Finances");
            Assert.AreEqual("Finances", dept.Name);
            Assert.AreEqual(1, dept.Id);
        }


        
    }
}
