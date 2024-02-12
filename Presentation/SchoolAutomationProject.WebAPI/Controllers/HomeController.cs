using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels;

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
        [HttpPost]
        public IActionResult CheckUserInfos(LoginUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
