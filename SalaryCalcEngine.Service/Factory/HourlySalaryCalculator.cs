using SalaryCalcEngine.Entity;

namespace SalaryCalcEngine.Service
{
    class HourlySalaryCalculator : ISalaryCalculator
    {
        public EmployeeModel CalculateSalary(Employee Employee)
        {
            return new EmployeeModel()
            {
                Id = Employee.Id,
                Name = Employee.Name,
                RoleName = Employee.RoleName,
                AnnualSalary = 120 * Employee.HourlySalary * 12
            };
        }
    }
}
