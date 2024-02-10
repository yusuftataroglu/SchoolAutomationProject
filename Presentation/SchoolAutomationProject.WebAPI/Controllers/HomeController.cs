using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;

namespace SchoolAutomationProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStudentReadRepository _studentReadRepository;

        public HomeController(IStudentReadRepository studentReadRepository)
        {
            _studentReadRepository = studentReadRepository;
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_studentReadRepository.GetAll());
        }
    }
}
