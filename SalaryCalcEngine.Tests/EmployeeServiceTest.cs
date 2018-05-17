using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryCalcEngine.Entity;
using SalaryCalcEngine.Service;

namespace SalaryCalcEngine.Tests
{
    [TestClass]
    public class EmployeeServiceTest
    {
        [TestMethod]
        public void GetEmployees()
        {
            EmployeeService service = new EmployeeService();
            // Arrange
            var employees = new List<Employee>();
            employees.Add(new Employee()
            {
                Id = 1,
                Name = "Test Employee 1",
                RoleName = "Tester",
                ContractTypeName = "HourlySalaryEmployee",
                HourlySalary = 1000
            });

            employees.Add(new Employee()
            {
                Id = 2,
                Name = "Test Employee 2",
                RoleName = "Tester",
                ContractTypeName = "MonthlySalaryEmployee",
                MonthlySalary = 5000
            });

            // Act
            var result = service.CalculateSalary(employees);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1440000, result.ElementAtOrDefault(0).AnnualSalary);
            Assert.AreEqual(60000, result.ElementAtOrDefault(1).AnnualSalary);
        }        
    }
}
