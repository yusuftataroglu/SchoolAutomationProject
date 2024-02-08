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

            List<Student> studentlist = new List<Student>
            {
                new Student{
                Id = Guid.NewGuid(),
                FirstName = "Yusuf",
                LastName = "Tataroğlu",
                Gender = Gender.Erkek,
                GraduatedSchool = "Dr. Nuri Bayar İ.Ö.O.",
                GPA = 99.2,
                IsPreRegistered = true,
                CreatedIpAddress = "127.0.0.1"
            },
              new Student{
                Id = Guid.NewGuid(),
                FirstName = "Yağmur",
                LastName = "Yaman",
                Gender = Gender.Erkek,
                GraduatedSchool = "Dr. Nuri Bayar İ.Ö.O.",
                GPA = 77.5,
                IsPreRegistered = true,
                CreatedIpAddress = "127.0.0.1"
            }
            };
            var student =await  _studentReadRepository.GetByIdAsync("BE1994D1-0035-4E7F-8526-787FF0840838");
            student.FirstName = "ecem";
            await _studentWriteRepository.SaveChangesAsync();
            //await _studentWriteRepository.AddRangeAsync(studentlist);
            return View();
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