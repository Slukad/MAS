using System.Web.Mvc;

namespace SalaryCalcEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Salary Calculation";

            return View();
        }
    }
}
