using System.Collections.Generic;

namespace SalaryCalcEngine.Service
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetEmployees(int? id);
        List<EmployeeModel> CalculateSalary(List<Entity.Employee> allEmployees);
    }
}
