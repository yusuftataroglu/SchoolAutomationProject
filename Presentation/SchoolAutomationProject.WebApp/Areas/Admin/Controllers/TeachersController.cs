using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.Tokens;
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
        public IActionResult GetTeachers()
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
                    MainCourse = teacher.MainCourse,
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
        public async Task<IActionResult> AddTeacher(WriteTeacherViewModel model, List<string> modelClassroomIds)
        {
            //todo schedule eklenebilecek!
            if (ModelState.IsValid)
            {
                AppUser user = new()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = $"{model.FirstName}{model.LastName}", //todo türkçe karakter hata verdi
                };
                var userCreationResult = await _userManager.CreateAsync(user);
                if (userCreationResult.Succeeded)
                {
                    var roleAssignmentResult = await _userManager.AddToRoleAsync(user, "Teacher");

                    if (roleAssignmentResult.Succeeded)
                    {
                        List<ClassroomTeacher> classroomTeachers = new();
                        Teacher teacher = new Teacher
                        {
                            FirstName = model.FirstName,
                            LastName = model.LastName,
                            Title = model.Title,
                            MainCourseId = Guid.Parse(model.MainCourseId),
                            UserId = user.Id,
                            ClassroomTeachers = classroomTeachers
                        };

                        foreach (var modelClassroomId in modelClassroomIds)
                        {
                            var classroomTeacher = new ClassroomTeacher
                            {
                                TeacherId = teacher.Id,
                                ClassroomId = Guid.Parse(modelClassroomId)
                            };
                            classroomTeachers.Add(classroomTeacher);
                        }
                        var result = await _teacherWriteRepository.AddAsync(teacher);
                        if (result)
                        {
                            var password = $"{model.FirstName[0].ToString().ToUpper()}{model.FirstName.Substring(1)}{model.LastName}{user.Id.ToString().Substring(0, 3)}-";
                            await _userManager.AddPasswordAsync(user, password);
                            await _teacherWriteRepository.SaveChangesAsync();
                            TempData["Success"] = "Öğretmen başarıyla eklendi";
                            return View(model);
                        }
                        else
                        {
                            TempData["Error"] = "Bir hata meydana geldi!";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["Error"] = "Öğretmene ait rol atanırken bir hata meydana geldi!";
                        return View(model);
                    }
                }
                else
                {
                    TempData["Error"] = "Öğretmene ait kullanıcı oluştururken bir hata meydana geldi!";
                    return View(model);
                }
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
                MainCourseId = teacher.MainCourseId.ToString(),
                ClassroomId = teacher.ClassroomTeachers.Select(x => x.ClassroomId.ToString()).ToList()
            };
            return View(teacherVM);
        } //todo tüm bilgiler güncellenecek!

        [HttpPost]
        public async Task<IActionResult> UpdateTeacher(WriteTeacherViewModel model, List<string> modelClassroomIds)
        {
            //todo schedule güncellenebilecek
            Teacher teacher = await _teacherReadRepository.GetByIdAsync(model.Id.ToString());
            List<ClassroomTeacher> classroomTeachers = new();

            if (teacher != null)
            {

                teacher.FirstName = model.FirstName;
                teacher.LastName = model.LastName;
                teacher.Title = model.Title;
                teacher.MainCourseId = Guid.Parse(model.MainCourseId);


                foreach (var modelClassroomId in modelClassroomIds)
                {
                    var classroomTeacher = new ClassroomTeacher
                    {
                        TeacherId = teacher.Id,
                        ClassroomId = Guid.Parse(modelClassroomId)
                    };
                    classroomTeachers.Add(classroomTeacher);
                }
                teacher.ClassroomTeachers = classroomTeachers;

                var result = _teacherWriteRepository.Update(teacher);
                if (result)
                {
                    await _teacherWriteRepository.SaveChangesAsync();
                    TempData["Success"] = "Güncelleme işlemi başarıyla gerçekleştirildi";
                    return RedirectToAction("GetTeachers");
                }
                else
                {
                    TempData["Error"] = "Güncelleme işleminde bir hata meydana geldi";
                    return View(model);
                }
            }
            else
            {
                TempData["Error"] = "Bu öğretmen veri tabanında bulunmuyor!";
                return RedirectToAction("GetTeachers");
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteTeacher(string id)
        {
            Teacher teacher = await _teacherReadRepository.GetByIdAsync(id);
            if (teacher != null)
            {
                var result = _teacherWriteRepository.Remove(teacher);
                if (result)
                {
                    AppUser user = await _userManager.FindByIdAsync(teacher.UserId);
                    if (user != null)
                    {
                        await _userManager.DeleteAsync(user);
                    }
                    await _teacherWriteRepository.SaveChangesAsync();
                    TempData["Success"] = "Silme işlemi başarıyla gerçekleştirildi";
                    return RedirectToAction("GetTeachers");
                }
                else
                {
                    TempData["Error"] = "Bir sorun oluştu!";
                    return RedirectToAction("GetTeachers");
                }
            }
            else
            {
                TempData["Error"] = "Bu öğretmen veri tabanındandan kaldırılmış!";
                return RedirectToAction("GetTeachers");
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetDetailsTeacher(string id)
        {
            Teacher teacher = await _teacherReadRepository.GetByIdAsync(id);
            if (teacher != null)
            {
                ReadTeacherViewModel model = new()
                {
                    Id = teacher.Id,
                    CreatedComputerName = teacher.CreatedComputerName,
                    CreatedDate = teacher.CreatedDate,
                    CreatedIpAddress = teacher.CreatedIpAddress,
                    UpdatedComputerName = teacher.UpdatedComputerName,
                    UpdatedDate = teacher.UpdatedDate,
                    UpdatedIpAddress = teacher.UpdatedIpAddress,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Title = teacher.Title,
                    MainCourse = teacher.MainCourse,
                    ClassroomTeachers = teacher.ClassroomTeachers,
                };
                return View(model);
            }
            TempData["Error"] = "Bu öğretmen veri tabanından kaldırılmış!";
            return RedirectToAction("GetTeachers");
        }
    }
}
