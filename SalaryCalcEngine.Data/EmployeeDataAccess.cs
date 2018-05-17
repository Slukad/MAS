using SalaryCalcEngine.Entity;
using System.Collections.Generic;
using System.Net.Http;

namespace SalaryCalcEngine.Data
{
    public class EmployeeDataAccess
    {
        static HttpClient client = new HttpClient();

        public EmployeeDataAccess()
        {
        }

        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            HttpResponseMessage response = client.GetAsync("http://masglobaltestapi.azurewebsites.net/api/Employees").Result;
            if (response.IsSuccessStatusCode)
            {
                employees = response.Content.ReadAsAsync<List<Employee>>().Result;
            }
            return employees;
        }

    }
}
