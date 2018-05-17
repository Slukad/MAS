using SalaryCalcEngine.Service;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SalaryCalcEngine.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeService _service = new EmployeeService();
        
        public IEnumerable<EmployeeModel> Get()
        {
            return _service.GetEmployees(null);
        }
        
        public IEnumerable<EmployeeModel> Get(int? id)
        {
            return _service.GetEmployees(id);
        }        
    }
}
