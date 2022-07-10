using Microsoft.AspNetCore.Mvc;

namespace MTC_Project.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
