using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Application.Repositories.ParentRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Application.ViewModels.ParentAreaViewModels.GradeViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Parent.Controllers
{
    [Area("Parent")]
    [Authorize(Roles = "Parent")]
    public class GradesController : GenericController<Grade, ReadGradeViewModel, IWriteViewModel>
    {
        private readonly IGradeReadRepository _gradeReadRepository;
        private readonly IGradeWriteRepository _gradeWriteRepository;
        private readonly IMapper _mapper;
        private readonly IFillEntityRelationshipsService _fillEntityRelationshipsService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly IParentReadRepository _parentReadRepository;

        public GradesController(
            IGradeReadRepository gradeReadRepository,
            IGradeWriteRepository gradeWriteRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            UserManager<AppUser> userManager,
            IStudentReadRepository studentReadRepository,
            IParentReadRepository parentReadRepository)
            : base(gradeReadRepository, gradeWriteRepository, mapper, fillEntityRelationshipsService)
        {
            _gradeReadRepository = gradeReadRepository;
            _gradeWriteRepository = gradeWriteRepository;
            _mapper = mapper;
            _fillEntityRelationshipsService = fillEntityRelationshipsService;
            _userManager = userManager;
            _studentReadRepository = studentReadRepository;
            _parentReadRepository = parentReadRepository;
        }

        public override async Task<IActionResult> GetByUsername(string userName, List<Grade>? entities)
        {
            try
            {
                ViewData["TableTitle"] = "Not Listesi";
                ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Alt Ders", "Sınav Numarası", "Not" };
                ViewData["CustomProperties"] = new List<string> { "StudentFullName", "SubCourseCode", "ExamNumber", "Score" };
                ViewData["ControllerName"] = "Grades";

                var user = await _userManager.FindByNameAsync(userName);
                var parent = await _parentReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefaultAsync();

                var studentList = parent.Students;
                var gradeList = _gradeReadRepository
                .GetWhere(g => studentList.Select(s => s.Id).ToList().Contains(g.StudentId.Value) && g.IsActive)
                .OrderByDescending(g => g.Student.FirstName)
                .ThenByDescending(g => g.ExamNumber)
                .ThenByDescending(g => g.SubCourse.Code)
                .ToList();


                return await base.GetByUsername(userName, gradeList);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Beklenmeyen bir hata oluştu: " + ex.Message;
                return RedirectToAction("GetByUsername", "Students", User.Identity.Name);
            }
        }

    }

}



