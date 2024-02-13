using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.TokenHelpers;
using SchoolAutomationProject.Application.ViewModels;
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

        public HomeController(ILogger<HomeController> logger,
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
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginUserViewModel model)
        {
            //ViewBag.Message = "";
            //if (ModelState.IsValid)
            //{
            //    var user = await _userManager.FindByNameAsync(model.UserName);
            //    if (user != null)
            //    {
            //        var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            //        if (result.Succeeded)
            //        {
            //            var roles = await _userManager.GetRolesAsync(user);
            //            ViewBag.Message = "Giriş başarılı";
            //            string token = _jwtProvider.GenerateJwt(user);
            //            if (roles.Contains("Admin"))
            //            {
            //                return RedirectToAction("Index", "Home", new { area = "Admin" , token });
            //            }
            //            else
            //            {
            //                return RedirectToAction("DeniedPage");
            //            }
            //        }
            //        else
            //        {
            //            ViewBag.Message = "Kullanıcı adı veya parola yanlış";
            //            return View(model);
            //        }
            //    }
            //    else
            //    {
            //        ViewBag.Message = "Böyle bir kullanıcı bulunamadı!";
            //        return View(model);
            //    }
            //}
            //else
            //{
            //    return View(model);

            //}
            return View();
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