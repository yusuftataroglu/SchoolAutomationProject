using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.WebApp.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class ClassroomsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly IClassroomReadRepository _classroomReadRepository;

        public ClassroomsController(
            IMapper mapper,
            UserManager<AppUser> userManager,
            IClassroomReadRepository classroomReadRepository)
        {
            _mapper = mapper;
            _userManager = userManager;
            _classroomReadRepository = classroomReadRepository;
        }

        public async Task<IActionResult> Get(string userName)
        {
            AppUser user = await _userManager.FindByNameAsync(userName);
            string userId = user.Id;

            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Sınıf Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Sınıf", "Kapasite", "Öğrenciler", "Öğretmenler" };
            ViewData["CustomProperties"] = new List<string> { "Name", "Capacity", "Students", "ClassroomTeachers" };
            ViewData["ControllerName"] = "Classrooms";

            var classroomList = _classroomReadRepository.GetAll()
            .Where(c => c.ClassroomTeachers.Any(ct => ct.Teacher.UserId == userId))
            .ToList();

            List<ReadClassroomViewModel> readViewModelList = _mapper.Map<List<ReadClassroomViewModel>>(classroomList);
            return View(readViewModelList);
        }
    }
}
