using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalcEngine.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string ContractTypeName { get; set; }
        public string RoleName { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
    }
}
