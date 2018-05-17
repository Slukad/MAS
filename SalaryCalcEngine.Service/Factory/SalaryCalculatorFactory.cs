namespace SalaryCalcEngine.Service
{
    class SalaryCalculatorFactory
    {        
        public virtual ISalaryCalculator CreateSalaryCalculator(string ContractTypeName)
        {
            switch (ContractTypeName)
            {
                case "HourlySalaryEmployee":
                    return new HourlySalaryCalculator();
                default:
                    return new MonthlySalaryCalculator();
            }
        }
    }
}
