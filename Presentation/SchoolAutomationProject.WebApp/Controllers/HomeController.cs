using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
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

            List<Student> studentList = new List<Student>{
                new Student
            {
                FirstName = "Yusuf",
                LastName = "Tataroğlu",
                Gender = Domain.Entities.Enums.Gender.Erkek,
                GraduatedSchool = "Dr. Nuri Bayar İ.Ö.O.",
                GPA = 69.3,
                IsPreRegistered = true,
                CreatedIpAddress = "127.0.0.1",
                ClassroomId = Guid.Parse("e2f05c32-2874-42b2-9561-cf50d147417c")
            },
                new Student
            {
                FirstName = "Yağmur",
                LastName = "Yaman",
                Gender = Domain.Entities.Enums.Gender.Kız,
                GraduatedSchool = "Dr. Nuri Bayar İ.Ö.O.",
                GPA = 69.3,
                IsPreRegistered = true,
                CreatedIpAddress = "127.0.0.1",
                ClassroomId = Guid.Parse("e2f05c32-2874-42b2-9561-cf50d147417c")
            }
            };
           await _studentWriteRepository.AddRangeAsync(studentList);
           await _studentWriteRepository.SaveChangesAsync();

            var getStudentList = _studentReadRepository.GetAll().ToList();
            return View(getStudentList);
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