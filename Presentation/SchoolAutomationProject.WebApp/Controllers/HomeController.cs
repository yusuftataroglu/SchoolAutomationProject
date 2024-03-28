using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.TokenHelpers;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AppUserViewModels;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.WebApp.Models;
using System.Diagnostics;

namespace SchoolAutomationProject.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IJwtProvider _jwtProvider;

        public HomeController(
            ILogger<HomeController> logger,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            IJwtProvider jwtProvider)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtProvider = jwtProvider;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync("yusuftataroglu");
            if (user==null)
            {
                AppUser newUser = new AppUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "yusuftataroglu",
                };
                await _userManager.CreateAsync(newUser,"yusufttr");
                await _userManager.AddToRoleAsync(newUser,"Admin");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        //string token = _jwtProvider.GenerateJwt(user);
                        TempData["Success"] = "Giriş Başarılı";
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["Error"] = "Giriş bilgilerinizi kontrol ediniz!";
                        return View(model);
                    }
                }
                else
                {
                    TempData["Error"] = "Böyle bir kullanıcı bulunamadı!";
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

        public IActionResult DeniedPage()
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