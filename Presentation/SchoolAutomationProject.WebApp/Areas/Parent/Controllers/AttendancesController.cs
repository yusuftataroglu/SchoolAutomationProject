using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Application.Repositories.ParentRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Application.ViewModels.ParentAreaViewModels.AttendanceViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Parent.Controllers
{
    [Area("Parent")]
    [Authorize(Roles = "Parent")]
    public class AttendancesController : GenericController<Attendance, ReadAttendanceViewModel, IWriteViewModel>
    {
        private readonly IAttendanceReadRepository _attendanceReadRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly IParentReadRepository _parentReadRepository;

        public AttendancesController(
            IAttendanceReadRepository attendanceReadRepository,
            IAttendanceWriteRepository attendanceWriteRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            UserManager<AppUser> userManager,
            IStudentReadRepository studentReadRepository,
            IParentReadRepository parentReadRepository)
            : base(attendanceReadRepository, attendanceWriteRepository, mapper, fillEntityRelationshipsService)
        {
            _attendanceReadRepository = attendanceReadRepository;
            _userManager = userManager;
            _studentReadRepository = studentReadRepository;
            _parentReadRepository = parentReadRepository;
        }

        public override async Task<IActionResult> Get(string userName, List<Attendance>? entities)
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Devamsızlık Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Devamsızlık Durumu", "Devamsızlık Tarihi", "Devamsızlık Yapılan Ders" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "AttendanceStatus", "AttendanceDateShort", "SubCourseCode" };
            ViewData["ControllerName"] = "Attendances";

            var user = await _userManager.FindByNameAsync(userName);
            var parent = await _parentReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();
            var attendanceList = _attendanceReadRepository
            .GetWhere(x => x.Student.ParentId == parent.Id)
            .OrderByDescending(x => x.Student.FirstName)
            .ThenByDescending(x => x.AttendanceDate)
            .ToList();
            return await base.Get(userName, attendanceList);
        }
        public override async Task<IActionResult> GetById(string id, List<Attendance>? attendances)
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Devamsızlık Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Devamsızlık Durumu", "Devamsızlık Tarihi", "Devamsızlık Yapılan Ders" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "AttendanceStatus", "AttendanceDateShort", "SubCourseCode" };
            ViewData["ControllerName"] = "Attendances";

            var attendanceList = _attendanceReadRepository.GetWhere(x => x.Student.Id.ToString() == id).OrderByDescending(x => x.AttendanceDate).ToList();
            return await base.GetById(id, attendanceList);

        }
    }
}
