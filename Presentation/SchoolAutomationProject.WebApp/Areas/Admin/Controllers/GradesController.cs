using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.GradeViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class GradesController : GenericController<Grade, ReadGradeViewModel, WriteGradeViewModel>
    {

        public GradesController(
            IGradeReadRepository readRepository,
            IGradeWriteRepository writeRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            IMapper mapper)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsService)

        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Not Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Alt Ders", "Sınav Numarası", "Not" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "SubCourseCode", "ExamNumber", "Score" };
            ViewData["ControllerName"] = "Grades";

            return base.Get();
        }
        public override async Task<IActionResult> Details(string id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Not Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Alt Ders", "Sınav Numarası", "Not" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "SubCourseCode", "ExamNumber", "Score" };
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteGradeViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(string id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteGradeViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(string id)
        {
            return await base.Delete(id);
        }
    }
}