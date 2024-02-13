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

        [HttpPost]
        public async Task<IActionResult> CheckUserInfosAsync(LoginUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
                    if (result.Succeeded)
                    {
                        return Ok("giriş başarılı");

                    }
                }
            }
            return BadRequest(ModelState);
        }
    }
}
