using Microsoft.VisualStudio.TestTools.UnitTesting;
using ETS.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETS.Entity;
using System.Data.SqlClient;

namespace ETS.Logic.Tests
{
    [TestClass()]
    public class EmployeeServicesTests
    {
        [TestMethod()]
        public void HrsLoggedTest()
        {
            // Arrange
            HoursLogged hl = new HoursLogged();
            EmpHour hrs = null;
            Status expectedResult = Status.Successfull;

            // Act
            Status actualResult = hl.HrsLogged(hrs);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }

    [TestClass()]
    public class EmployeeServicesTests1
    {
        [TestMethod()]
        public void FindEmpTest_ValidTest1()
        {
            // Arrange
            EmployeeServices serv = new EmployeeServices();
            int id = 1;
            Status expectedStatus = Status.Successfull;
            string expectedFName = "Anna";
            string expectedLName = "Nguyen";

            // Act
            StatusData<Employee> actualResult =  serv.FindEmp(id);
            // Assert
            Assert.AreEqual(expectedStatus, actualResult.StatusResult);
            Assert.AreEqual(expectedFName, actualResult.Data.FName);
            Assert.AreEqual(expectedLName, actualResult.Data.LName);
        }

        [TestMethod()]
        public void FindEmpTest_ValidTest2()
        {
            // Arrange
            EmployeeServices serv = new EmployeeServices();
            Status expectedStatus = Status.Successfull;
            int id = 10000;
            

            // Act
            StatusData<Employee> actualResult = serv.FindEmp(id);
            // Assert
            Assert.AreEqual(expectedStatus, actualResult.StatusResult);
            Assert.IsNull(actualResult.Data);
            
        }
        [TestMethod()]
        public void ListDetailsTest_ValidNotEmpty()
        {
            // Arrange
            EmployeeServices serv = new EmployeeServices();
            Status expectedStatus = Status.Successfull;


            // Act
            StatusData<List<Employee>> actualResult = serv.ListDetails();
            // Assert
            Assert.AreEqual(expectedStatus, actualResult.StatusResult);
            Assert.IsNotNull(actualResult.Data);
            Assert.AreNotEqual(0, actualResult.Data.Count);
        }
        [TestMethod()]
        //[ExpectedException()]
        public void SavedEmpTest_InvalidDataNull1()
        {
            // Arrange
            EmployeeServices serv = new EmployeeServices();
            Employee emp = null;
            Status expectedStatus = Status.Unsuccessfull;
          
            // Act
            Status actualResult = serv.SavedEmp(emp);
            // Assert
            Assert.AreEqual(expectedStatus, actualResult);
        }

        [TestMethod()]
        //[ExpectedException()]
        public void SavedEmpTest_InvalidExistingID()
        {
            // Arrange
            EmployeeServices serv = new EmployeeServices();
            Status expectedStatus = Status.Successfull;
            Employee emp = new Employee() ;
            int id = 1;
            emp.EmpID = id;
            emp.FName = "Anna";
            emp.LName = "Nguyen";
            emp.Email = "Anna.Nguyen@gmail.com";
            emp.DOB = new DateTime(1984,12,28);
            emp.Phone = "0297097189";

            // Act
            Status actualResult = serv.SavedEmp(emp);

            // Assert
            Assert.AreEqual(expectedStatus, actualResult);

        }
    }
}