using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class AttendancesController : GenericController<Attendance, ReadAttendanceViewModel, WriteAttendanceViewModel>
    {
        public AttendancesController(
            IAttendanceReadRepository readRepository,
            IAttendanceWriteRepository writeRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService
            )
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsService)
        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Devamsızlık Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Devamsızlık Durumu", "Devamsızlık Tarihi", "Devamsızlık Yapılan Ders" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "AttendanceStatus", "AttendanceDateShort", "SubCourseCode" };
            ViewData["ControllerName"] = "Attendances";
            return base.Get();
        }

        public async Task<IActionResult> AddWithStudentInfos(Guid id)
        {
            var attendanceVM = new WriteAttendanceViewModel
            {
                StudentId = id,
                AttendanceDate = DateTime.Today,
                AttendanceStatus = Domain.Entities.Enums.AttendanceStatus.Mevcut,
            };
            return View(attendanceVM);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteAttendanceViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(Guid id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteAttendanceViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }
    }
}
