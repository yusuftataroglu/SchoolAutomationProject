using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly IStudentReadRepository _studentReadRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(IStudentReadRepository studentReadRepository,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _studentReadRepository = studentReadRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            return Ok(await _userManager.GetUserNameAsync(new() { UserName = "yusuftataroglu" }));
        }
        [HttpPost]
        public async Task<IActionResult> CheckUserInfosAsync(LoginUserViewModel model)
        {
            AppUser user = new AppUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = model.UserName+"@gmail.com",
                UserName = model.UserName,
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            return Ok();

            
        }
    }
}
