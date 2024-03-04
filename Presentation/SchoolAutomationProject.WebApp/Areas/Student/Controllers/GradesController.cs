using Microsoft.AspNetCore.Mvc;

namespace SchoolAutomationProject.WebApp.Areas.Student.Controllers
{
    public class GradesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
