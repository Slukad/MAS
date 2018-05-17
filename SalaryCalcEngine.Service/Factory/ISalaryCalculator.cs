using SalaryCalcEngine.Entity;

namespace SalaryCalcEngine.Service
{
    interface ISalaryCalculator
    {        
        EmployeeModel CalculateSalary(Employee Employee);
    }
}