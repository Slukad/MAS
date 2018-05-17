
using SalaryCalcEngine.Data;
using System.Collections.Generic;

namespace SalaryCalcEngine.Service
{
    public class EmployeeService : IEmployeeService
    {
        SalaryCalculatorFactory _salaryCalculatorFactory;
        EmployeeDataAccess _employeeDataAccess;

        public EmployeeService()
        {
            _salaryCalculatorFactory = new SalaryCalculatorFactory();
            _employeeDataAccess = new EmployeeDataAccess();
        }

        public List<EmployeeModel> GetEmployees(int? id)
        {
            var allEmployees = _employeeDataAccess.GetEmployees();

            if (id.HasValue)
            {
                allEmployees = allEmployees.FindAll(e => e.Id == id.Value);
            }

            return CalculateSalary(allEmployees);
        }

        public List<EmployeeModel> CalculateSalary(List<Entity.Employee> allEmployees)
        {
            var employees = new List<EmployeeModel>();
            foreach (var employee in allEmployees)
            {
                var salaryCalculator = _salaryCalculatorFactory.CreateSalaryCalculator(employee.ContractTypeName);
                employees.Add((salaryCalculator.CalculateSalary(employee)));
            }
            return employees;
        }
    }
}
