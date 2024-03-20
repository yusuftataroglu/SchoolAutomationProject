using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Application.ViewModels.ParentAreaViewModels.StudentViewModels;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Parent.Controllers
{
    [Area("Parent")]
    [Authorize(Roles ="Parent")]
    public class StudentsController : GenericController<Domain.Entities.CustomTables.Student, ReadStudentViewModel, IWriteViewModel>
    {
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly UserManager<AppUser> _userManager;

        public StudentsController(
            IStudentReadRepository studentReadRepository,
            IStudentWriteRepository studentWriteRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            UserManager<AppUser> userManager)
            : base(studentReadRepository, studentWriteRepository, mapper, fillEntityRelationshipsService)
        {
            _studentReadRepository = studentReadRepository;
            _userManager = userManager;
        }

        public override async Task<IActionResult> GetByUsername(string userName, List<Domain.Entities.CustomTables.Student>? entities)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var studentList = _studentReadRepository.GetWhere(x => x.Parent.UserId == user.Id).ToList();
            ViewData["TableTitle"] = "Öğrenci Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Okul No", "Ad", "Soyad", "Cinsiyet", "Bitirdiği Okul", "Bitirdiği Okuldaki Not Ortalaması", "Ön Kayıt Durumu", "Devamsızlık Sayısı", "Devam Etme Durumu", "Sınıf", "Belgeler" };
            ViewData["CustomProperties"] = new List<string> { "RegistrationNumber", "FirstName", "LastName", "Gender", "GraduatedSchool", "GPA", "IsPreRegistered", "TotalAbsenceCount", "ContinuationStatus", "Classroom", "Achievements" };
            ViewData["ControllerName"] = "Students";
            return await base.GetByUsername(userName, studentList);
        }
    }
}
