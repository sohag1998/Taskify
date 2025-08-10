using Microsoft.AspNetCore.Mvc;

namespace Taskify.Web.Controllers
{
    public class EmployeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
