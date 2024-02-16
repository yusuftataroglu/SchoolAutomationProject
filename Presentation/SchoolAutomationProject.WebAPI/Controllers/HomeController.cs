using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SchoolAutomationProject.Application.Helpers.TokenHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.AppUserViewModels;
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
        private readonly IJwtProvider _jwtProvider;

        public HomeController(
            IStudentReadRepository studentReadRepository,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IJwtProvider jwtProvider)
        {
            _studentReadRepository = studentReadRepository;
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtProvider = jwtProvider;
        }

        [HttpGet]
        private IActionResult Index()
        {
            return Ok();

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    var user = await _userManager.FindByNameAsync(model.UserName);
            //    if (user == null) return BadRequest("Kullanıcı bulunamadı!");
            //    var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            //    if (result.Succeeded)
            //    {
            //        string token = _jwtProvider.GenerateJwt(user);
                    
            //    }
            //    else
            //    {
            //        return BadRequest("Kullanıcı adı veya şifre yanlış!");
            //    }
            //}
            //else
            //{
            //    return BadRequest(ModelState);
            //}
            return Ok(model);
        }
    }
}
