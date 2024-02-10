using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Persistence.Repositories.AttendanceRepositories;
using SchoolAutomationProject.WebApp.Models;
using System.Diagnostics;

namespace SchoolAutomationProject.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly IStudentWriteRepository _studentWriteRepository;
        private readonly IAttendanceReadRepository _attendanceReadRepository;

        public HomeController(
            ILogger<HomeController> logger,
            IStudentReadRepository studentReadRepository,
            IStudentWriteRepository studentWriteRepository,
            IAttendanceReadRepository attendanceReadRepository)
        {
            _studentReadRepository = studentReadRepository;
            _studentWriteRepository = studentWriteRepository;
            _attendanceReadRepository = attendanceReadRepository;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var studentList = _studentReadRepository.GetAll().ToList();
            
                
            return View(studentList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}