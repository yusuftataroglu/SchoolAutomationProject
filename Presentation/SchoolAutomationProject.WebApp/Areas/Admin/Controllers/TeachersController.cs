using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using NuGet.DependencyResolver;
using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.Repositories.MainCourseRepositories;
using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Application.ViewModels;
using SchoolAutomationProject.Application.ViewModels.TeacherViewModels;
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
                    Title = teacher.Title,
                    ClassroomTeachers = teacher.ClassroomTeachers,
                    TeacherSchedules = teacher.TeacherSchedules
                };
                teacherVMList.Add(teacherVM);
            }
            return View(teacherVMList);
        }

        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTeacher(WriteTeacherViewModel model, List<string> classrooms)
        {
            if (ModelState.IsValid)
            {
                List<ClassroomTeacher> classroomTeachers = new();
                Teacher teacher = new Teacher
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Title = model.Title,
                    MainCourseId = Guid.Parse(model.MainCourseId),
                    ClassroomTeachers = classroomTeachers
                };

                foreach (var classroomId in classrooms)
                {
                    var classroomTeacher = new ClassroomTeacher
                    {
                        TeacherId = teacher.Id,
                        ClassroomId = Guid.Parse(classroomId)
                    };
                    classroomTeachers.Add(classroomTeacher);
                }
                await _teacherWriteRepository.AddAsync(teacher);
                await _teacherWriteRepository.SaveChangesAsync();
                TempData["Success"] = "Öğretmen başarıyla eklendi";
                return View();
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTeacher(Guid id)
        {
            var teacher = await _teacherReadRepository.GetByIdAsync(id.ToString());
            var teacherVM = new WriteTeacherViewModel
            {
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                Title = teacher.Title,
                MainCourseId = teacher.MainCourseId.ToString()
            };
            return View(teacherVM);
        } //todo tüm bilgiler güncellenecek!

        [HttpPost]
        public async Task<IActionResult> UpdateTeacher(WriteTeacherViewModel model, Guid selectedMainCourse)
        {
            Teacher teacher = await _teacherReadRepository.GetByIdAsync(model.Id.ToString());
            if (teacher != null)
            {
                teacher.FirstName = model.FirstName;
                teacher.LastName = model.LastName;
                teacher.Title = model.Title;
                teacher.MainCourseId = selectedMainCourse;

                var result = _teacherWriteRepository.Update(teacher);
                await _teacherWriteRepository.SaveChangesAsync();
                if (result)
                {
                    TempData["Success"] = "Güncelleme işlemi başarıyla gerçekleştirildi";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Error"] = "Güncelleme işleminde bir hata meydana geldi"; //todo hata detayı yazılabilir.
                    return View(model);
                }
            }
            else
            {
                TempData["Error"] = "Bu öğretmen veri tabanında bulunmuyor!";
                return RedirectToAction("Index");
            }
        }
    }
}
