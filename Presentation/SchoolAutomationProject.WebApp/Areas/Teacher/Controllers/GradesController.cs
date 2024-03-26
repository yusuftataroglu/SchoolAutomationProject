using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.GradeViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class GradesController : GenericController<Grade, ReadGradeViewModel, WriteGradeViewModel>
    {
        private readonly IGradeReadRepository _gradeReadRepository;
        private readonly IGradeWriteRepository _gradeWriteRepository;
        private readonly IMapper _mapper;
        private readonly IFillEntityRelationshipsService _fillEntityRelationshipsService;
        private readonly UserManager<AppUser> _userManager;
        private readonly ITeacherReadRepository _teacherReadRepository;
        private readonly IStudentReadRepository _studentReadRepository;

        public GradesController(
            IGradeReadRepository gradeReadRepository,
            IGradeWriteRepository gradeWriteRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            UserManager<AppUser> userManager,
            ITeacherReadRepository teacherReadRepository,
            IStudentReadRepository studentReadRepository)
            : base(gradeReadRepository, gradeWriteRepository, mapper, fillEntityRelationshipsService)
        {
            _gradeReadRepository = gradeReadRepository;
            _gradeWriteRepository = gradeWriteRepository;
            _mapper = mapper;
            _fillEntityRelationshipsService = fillEntityRelationshipsService;
            _userManager = userManager;
            _teacherReadRepository = teacherReadRepository;
            _studentReadRepository = studentReadRepository;
        }

        public override async Task<IActionResult> GetByUsername(string userName, List<Grade>? entities)
        {
            ViewData["TableTitle"] = "Not Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Alt Ders", "Sınav Numarası", "Not" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "SubCourseCode", "ExamNumber", "Score" };
            ViewData["ControllerName"] = "Grades";

            var user = await _userManager.FindByNameAsync(userName);
            var teacher = await _teacherReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();

            var classroomIds = teacher.ClassroomTeachers.Select(ct => ct.ClassroomId).ToList();
            var studentList = _studentReadRepository
                .GetWhere(s => s.ClassroomId.HasValue && classroomIds.Contains(s.ClassroomId.Value))
                .ToList();
            var gradeList = _gradeReadRepository
            .GetWhere(g => studentList.Select(s => s.Id).ToList().Contains(g.StudentId.Value) && g.IsActive)
            .OrderByDescending(g => g.Student.FirstName)
            .ThenByDescending(g => g.ExamNumber)
            .ThenByDescending(g => g.SubCourse.Code)
            .ToList();


            return await base.GetByUsername(userName, gradeList);
        }
        public async Task<IActionResult> AddWithStudentInfos(Guid id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var teacher = await _teacherReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();

            var classroomIds = teacher.ClassroomTeachers.Select(ct => ct.ClassroomId).ToList();
            var studentList = _studentReadRepository
                .GetWhere(s => s.ClassroomId.HasValue && classroomIds.Contains(s.ClassroomId.Value))
                .ToList();
            ViewData["StudentList"] = studentList;
            ViewData["SubCourseList"] = teacher.MainCourse.SubCourses.ToList();

            var GradeVM = new WriteGradeViewModel
            {
                Id=Guid.NewGuid(),
                StudentId = id,
            };
            return View(GradeVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddWithStudentInfos(WriteGradeViewModel modelVM)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var teacher = await _teacherReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();

            var classroomIds = teacher.ClassroomTeachers.Select(ct => ct.ClassroomId).ToList();
            var studentList = _studentReadRepository
                .GetWhere(s => s.ClassroomId.HasValue && classroomIds.Contains(s.ClassroomId.Value))
                .ToList();
            ViewData["StudentList"] = studentList;
            ViewData["SubCourseList"] = teacher.MainCourse.SubCourses.ToList();

            if (ModelState.IsValid)
            {
                Grade entity = _mapper.Map<Grade>(modelVM);
                await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, nameof(Add));
                var result = await _gradeWriteRepository.AddAsync(entity);
                if (result)
                {
                    await _gradeWriteRepository.SaveChangesAsync();
                    TempData["Success"] = "Ekleme İşlemi Başarıyla Tamamlandı";
                    return RedirectToAction(nameof(GetByUsername), new { userName = User.Identity.Name });
                }
                else
                {
                    TempData["Error"] = "Bir Hata Meydana Geldi!";
                    return View(modelVM);
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(modelVM);
            }
        }
        public async Task<IActionResult> AddGrade()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var teacher = await _teacherReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();

            var classroomIds = teacher.ClassroomTeachers.Select(ct => ct.ClassroomId).ToList();
            var studentList = _studentReadRepository
                .GetWhere(s => s.ClassroomId.HasValue && classroomIds.Contains(s.ClassroomId.Value))
                .ToList();
            ViewData["StudentList"] = studentList;
            ViewData["SubCourseList"] = teacher.MainCourse.SubCourses.ToList();
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddGrade(WriteGradeViewModel modelVM)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var teacher = await _teacherReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();

            var classroomIds = teacher.ClassroomTeachers.Select(ct => ct.ClassroomId).ToList();
            var studentList = _studentReadRepository
                .GetWhere(s => s.ClassroomId.HasValue && classroomIds.Contains(s.ClassroomId.Value))
                .ToList();
            ViewData["StudentList"] = studentList;
            ViewData["SubCourseList"] = teacher.MainCourse.SubCourses.ToList();
            if (ModelState.IsValid)
            {
                Grade entity = _mapper.Map<Grade>(modelVM);
                await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, nameof(Add));
                var result = await _gradeWriteRepository.AddAsync(entity);
                if (result)
                {
                    await _gradeWriteRepository.SaveChangesAsync();
                    TempData["Success"] = "Ekleme İşlemi Başarıyla Tamamlandı";
                    return RedirectToAction(nameof(GetByUsername), new { userName = User.Identity.Name });
                }
                else
                {
                    TempData["Error"] = "Bir Hata Meydana Geldi!";
                    return View(modelVM);
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(modelVM);
            }
        }

        public async Task<IActionResult> UpdateGrade(Guid id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var teacher = await _teacherReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();

            var classroomIds = teacher.ClassroomTeachers.Select(ct => ct.ClassroomId).ToList();
            var studentList = _studentReadRepository
                .GetWhere(s => s.ClassroomId.HasValue && classroomIds.Contains(s.ClassroomId.Value))
                .ToList();
            ViewData["StudentList"] = studentList;
            ViewData["SubCourseList"] = teacher.MainCourse.SubCourses.ToList();
            Grade entity = await _gradeReadRepository.GetActiveByIdAsync(id);
            if (entity != null)
            {
                WriteGradeViewModel modelVM = _mapper.Map<WriteGradeViewModel>(entity);
                return View(modelVM);
            }
            else
            {
                TempData["Error"] = "Bu Veri Silinmiş!";
                return RedirectToAction(nameof(GetByUsername), new { userName = User.Identity.Name });
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateGrade(WriteGradeViewModel modelVM)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var teacher = await _teacherReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();

            var classroomIds = teacher.ClassroomTeachers.Select(ct => ct.ClassroomId).ToList();
            var studentList = _studentReadRepository
                .GetWhere(s => s.ClassroomId.HasValue && classroomIds.Contains(s.ClassroomId.Value))
                .ToList();
            ViewData["StudentList"] = studentList;
            ViewData["SubCourseList"] = teacher.MainCourse.SubCourses.ToList();
            if (ModelState.IsValid)
            {
                Grade entity = await _gradeReadRepository.GetActiveByIdAsync(modelVM.Id);
                if (entity != null)
                {
                    var resultUpdate = _gradeWriteRepository.Update(entity, modelVM);
                    if (resultUpdate)
                    {
                        await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, $"{nameof(Update)}Post");
                        await _gradeWriteRepository.SaveChangesAsync();
                        TempData["Success"] = "Güncelleme İşlemi Başarıyla Tamamlandı";
                        return RedirectToAction(nameof(GetByUsername), new { userName = User.Identity.Name });
                    }
                    else
                    {
                        TempData["Error"] = "Bir Hata Meydana Geldi!";
                        return View(modelVM);
                    }
                }
                else
                {
                    TempData["Error"] = "Bu Veri Silinmiş!";
                    return RedirectToAction(nameof(GetByUsername), new { userName = User.Identity.Name });
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(modelVM);
            }
        }

        public override async Task<IActionResult> Delete(Guid id)
        {
            await _gradeWriteRepository.RemoveByIdAsync(id);
            await _gradeWriteRepository.SaveChangesAsync();
            TempData["Success"] = "Silme İşlemi Başarıyla Tamamlandı";
            return RedirectToAction(nameof(GetByUsername), new { userName = User.Identity.Name });
        }
    }
}
