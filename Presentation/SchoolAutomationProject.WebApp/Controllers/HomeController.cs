using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.WebApp.Models;
using System.Diagnostics;

namespace SchoolAutomationProject.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly IStudentWriteRepository _studentWriteRepository;

        public HomeController(ILogger<HomeController> logger, IStudentReadRepository studentReadRepository, IStudentWriteRepository studentWriteRepository)
        {
            _studentReadRepository = studentReadRepository;
            _studentWriteRepository = studentWriteRepository;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {

            //List<Student> studentlist = new List<Student>
            //{
            //    new Student{
            //    Id = Guid.NewGuid(),
            //    FirstName = "Yusuf",
            //    LastName = "Tataroğlu",
            //    Gender = Gender.Erkek,
            //    GraduatedSchool = "Dr. Nuri Bayar İ.Ö.O.",
            //    GPA = 99.2,
            //    IsPreRegistered = true,
            //},
            //  new Student{
            //    Id = Guid.NewGuid(),
            //    FirstName = "Yağmur",
            //    LastName = "Yaman",
            //    Gender = Gender.Kız,
            //    GraduatedSchool = "Dr. Nuri Bayar İ.Ö.O.",
            //    GPA = 77.5,
            //    IsPreRegistered = true,
            //}
            //};
            //await _studentWriteRepository.AddRangeAsync(studentlist);
            
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