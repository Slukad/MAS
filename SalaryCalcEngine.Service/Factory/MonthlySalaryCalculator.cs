using SalaryCalcEngine.Entity;

namespace SalaryCalcEngine.Service
{
    class MonthlySalaryCalculator : ISalaryCalculator
    {
        public EmployeeModel CalculateSalary(Employee Employee)
        {
            return new EmployeeModel()
            {
                Id = Employee.Id,
                Name = Employee.Name,
                RoleName = Employee.RoleName,
                AnnualSalary = Employee.MonthlySalary * 12
            };
        }
    }
}
