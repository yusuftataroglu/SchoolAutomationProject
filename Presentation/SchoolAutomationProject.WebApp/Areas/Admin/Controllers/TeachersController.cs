using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using NuGet.DependencyResolver;
using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.Repositories.MainCourseRepositories;
using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Application.ViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TeachersController : Controller
    {
        private readonly ITeacherReadRepository _teacherReadRepository;
        private readonly ITeacherWriteRepository _teacherWriteRepository;
        private readonly IClassroomReadRepository _classroomReadRepository;
        private readonly IMainCourseReadRepository _mainCourseReadRepository;
        private readonly UserManager<AppUser> _userManager;

        public TeachersController(
            ITeacherReadRepository teacherReadRepository,
            ITeacherWriteRepository teacherWriteRepository,
            IClassroomReadRepository classroomReadRepository,
            IMainCourseReadRepository mainCourseReadRepository,
            UserManager<AppUser> userManager)
        {
            _teacherReadRepository = teacherReadRepository;
            _teacherWriteRepository = teacherWriteRepository;
            _classroomReadRepository = classroomReadRepository;
            _mainCourseReadRepository = mainCourseReadRepository;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var teacherList = _teacherReadRepository.GetAll().ToList();
            List<ReadTeacherViewModel> teacherVMList = new List<ReadTeacherViewModel>();

            foreach (var teacher in teacherList)
            {
                var teacherVM = new ReadTeacherViewModel
                {
                    Id = teacher.Id,
                    CreatedDate = teacher.CreatedDate,
                    CreatedComputerName = teacher.CreatedComputerName,
                    CreatedIpAddress = teacher.CreatedIpAddress,
                    UpdatedDate = teacher.UpdatedDate,
                    UpdatedComputerName = teacher.UpdatedComputerName,
                    UpdatedIpAddress = teacher.UpdatedIpAddress,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Role = teacher.Role,
                    Department = teacher.MainCourse.Name,
                    ClassroomTeachers = teacher.ClassroomTeachers,
                    TeacherSchedules = teacher.TeacherSchedules
                };
                teacherVMList.Add(teacherVM);
            }
            return View(teacherVMList);
        }
    }
}
