using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers;
using SchoolAutomationProject.Persistence.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;
using SchoolAutomationProject.Persistence.Repositories.StudentRepositories;
using SchoolAutomationProject.WebApp.Controllers;
using System.Linq;

namespace SchoolAutomationProject.WebApp.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class AttendancesController : GenericController<Attendance, ReadAttendanceViewModel, WriteAttendanceViewModel>
    {
        private readonly IAttendanceReadRepository _attendanceReadRepository;
        private readonly IAttendanceWriteRepository _attendanceWriteRepository;
        private readonly IMapper _mapper;
        private readonly IFillEntityRelationshipsService _fillEntityRelationshipsService;
        private readonly UserManager<AppUser> _userManager;
        private readonly ITeacherReadRepository _teacherReadRepository;
        private readonly IStudentReadRepository _studentReadRepository;

        public AttendancesController(
            IAttendanceReadRepository attendanceReadRepository,
            IAttendanceWriteRepository attendanceWriteRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            UserManager<AppUser> userManager,
            ITeacherReadRepository teacherReadRepository,
            IStudentReadRepository studentReadRepository
            )
            : base(attendanceReadRepository, attendanceWriteRepository, mapper, fillEntityRelationshipsService)
        {
            _attendanceReadRepository = attendanceReadRepository;
            _attendanceWriteRepository = attendanceWriteRepository;
            _mapper = mapper;
            _fillEntityRelationshipsService = fillEntityRelationshipsService;
            _userManager = userManager;
            _teacherReadRepository = teacherReadRepository;
            _studentReadRepository = studentReadRepository;
        }

        public override async Task<IActionResult> GetByUsername(string userName, List<Attendance>? entities)
        {
            ViewData["TableTitle"] = "Devamsızlık Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Devamsızlık Durumu", "Devamsızlık Tarihi", "Devamsızlık Yapılan Ders" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "AttendanceStatus", "AttendanceDateShort", "SubCourseCode" };
            ViewData["ControllerName"] = "Attendances";

            var user = await _userManager.FindByNameAsync(userName);
            var teacher = await _teacherReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();

            var classroomIds = teacher.ClassroomTeachers.Select(ct => ct.ClassroomId).ToList();
            var studentList = _studentReadRepository
                .GetWhere(s => s.ClassroomId.HasValue && classroomIds.Contains(s.ClassroomId.Value))
                .ToList();
            var attendanceList = _attendanceReadRepository
            .GetWhere(a => studentList.Select(s => s.Id).ToList().Contains(a.StudentId.Value) && a.IsActive)
            .OrderByDescending(a => a.Student.FirstName)
            .ThenByDescending(a => a.AttendanceDate)
            .ToList();


            return await base.GetByUsername(userName, attendanceList);
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

            var attendanceVM = new WriteAttendanceViewModel
            {
                Id=Guid.NewGuid(),
                StudentId = id,
                AttendanceDate = DateTime.Today,
                AttendanceStatus = Domain.Entities.Enums.AttendanceStatus.Mevcut,
            };
            return View(attendanceVM);
        }
        [HttpPost]
        public async Task<IActionResult> AddWithStudentInfos(WriteAttendanceViewModel modelVM)
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
                Attendance entity = _mapper.Map<Attendance>(modelVM);
                await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, nameof(Add));
                var result = await _attendanceWriteRepository.AddAsync(entity);
                if (result)
                {
                    await _attendanceWriteRepository.SaveChangesAsync();
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

        public async Task<IActionResult> AddAttendance()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var teacher = await _teacherReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();

            var classroomIds = teacher.ClassroomTeachers.Select(ct => ct.ClassroomId).ToList();
            var studentList = _studentReadRepository
                .GetWhere(s => s.ClassroomId.HasValue && classroomIds.Contains(s.ClassroomId.Value))
                .ToList();
            ViewData["StudentList"]=studentList;
            ViewData["SubCourseList"] = teacher.MainCourse.SubCourses.ToList();
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddAttendance(WriteAttendanceViewModel modelVM)
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
                Attendance entity = _mapper.Map<Attendance>(modelVM);
                await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, nameof(Add));
                var result = await _attendanceWriteRepository.AddAsync(entity);
                if (result)
                {
                    await _attendanceWriteRepository.SaveChangesAsync();
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

        public async Task<IActionResult> UpdateAttendance(Guid id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var teacher = await _teacherReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();

            var classroomIds = teacher.ClassroomTeachers.Select(ct => ct.ClassroomId).ToList();
            var studentList = _studentReadRepository
                .GetWhere(s => s.ClassroomId.HasValue && classroomIds.Contains(s.ClassroomId.Value))
                .ToList();
            ViewData["StudentList"] = studentList;
            ViewData["SubCourseList"] = teacher.MainCourse.SubCourses.ToList();

            Attendance entity = await _attendanceReadRepository.GetAllActivesByIdAsync(id);
            if (entity != null)
            {
                WriteAttendanceViewModel modelVM = _mapper.Map<WriteAttendanceViewModel>(entity);
                return View(modelVM);
            }
            else
            {
                TempData["Error"] = "Bu Veri Silinmiş!";
                return RedirectToAction(nameof(GetByUsername), new { userName = User.Identity.Name });
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAttendance(WriteAttendanceViewModel modelVM)
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
                Attendance entity = await _attendanceReadRepository.GetAllActivesByIdAsync(modelVM.Id);
                if (entity != null)
                {
                    var resultUpdate = _attendanceWriteRepository.Update(entity, modelVM);
                    if (resultUpdate)
                    {
                        await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, $"{nameof(Update)}Post");
                        await _attendanceWriteRepository.SaveChangesAsync();
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
            await _attendanceWriteRepository.RemoveByIdAsync(id);
            await _attendanceWriteRepository.SaveChangesAsync();
            TempData["Success"] = "Silme İşlemi Başarıyla Tamamlandı";
            return RedirectToAction(nameof(GetByUsername), new { userName = User.Identity.Name });
        }
    }
}
