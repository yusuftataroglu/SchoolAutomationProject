using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Application.ViewModels.StudentAreaViewModels.AttendanceViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class AttendancesController : GenericController<Attendance, ReadAttendanceViewModel, IWriteViewModel>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly IAttendanceReadRepository _attendanceReadRepository;

        public AttendancesController(
            IAttendanceReadRepository attendanceReadRepository,
            IAttendanceWriteRepository attendanceWriteRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            UserManager<AppUser> userManager,
            IStudentReadRepository studentReadRepository)
            : base(attendanceReadRepository, attendanceWriteRepository, mapper, fillEntityRelationshipsService)
        {
            _attendanceReadRepository = attendanceReadRepository;
            _userManager = userManager;
            _studentReadRepository = studentReadRepository;
        }

        public override async Task<IActionResult> GetByUsername(string userName, List<Attendance>? attendanceViewModels)
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Devamsızlık Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Devamsızlık Tarihi", "Devamsızlık Durumu", "Devamsızlık Yapılan Ders" };
            ViewData["CustomProperties"] = new List<string> { "AttendanceDateShort", "AttendanceStatus", "SubCourseCode" };
            ViewData["ControllerName"] = "Attendances";

            AppUser user = await _userManager.FindByNameAsync(userName);
            var student = _studentReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefault();
            List<Attendance> attendanceList = _attendanceReadRepository.GetWhere(x => x.StudentId == student.Id && x.IsActive).OrderByDescending(x=> x.AttendanceDate).ToList();
            return await base.GetByUsername(userName, attendanceList);

        }
    }
}
