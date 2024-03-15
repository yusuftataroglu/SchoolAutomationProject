using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Application.ViewModels.StudentAreaViewModels.GradeViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class GradesController : GenericController<Grade, ReadGradeViewModel, IWriteViewModel>
    {
        private readonly IGradeReadRepository _gradeReadRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly IStudentReadRepository _studentReadRepository;

        public GradesController(
            IGradeReadRepository gradeReadRepository,
            IGradeWriteRepository gradeWriteRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            UserManager<AppUser> userManager,
            IStudentReadRepository studentReadRepository)
            : base(gradeReadRepository, gradeWriteRepository, mapper, fillEntityRelationshipsService)
        {
            _gradeReadRepository = gradeReadRepository;
            _userManager = userManager;
            _studentReadRepository = studentReadRepository;
        }


        public override async Task<IActionResult> GetByUsername(string userName, List<Grade>? entities)
        {
            var user = await _userManager.FindByNameAsync(userName);
            var student = _studentReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefault();
            var gradeList = _gradeReadRepository.GetWhere(x => x.StudentId == student.Id).ToList();

            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Not Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Alt Ders", "Sınav Numarası", "Not" };
            ViewData["CustomProperties"] = new List<string> { "SubCourseCode", "ExamNumber", "Score" };
            ViewData["ControllerName"] = "Grades";
            return await base.GetByUsername(userName, gradeList);
        }

        //public override async Task<IActionResult> Add(WriteGradeViewModel modelVM)
        //{
        //    return await base.Add(modelVM);
        //}
    }
}
