using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AchievementViewModels;
using SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.GradeViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Teacher.Controllers
{
    public class GradesController : GenericController<Grade, ReadGradeViewModel, WriteGradeViewModel>
    {
        public GradesController(
            IReadRepository<Grade> readRepository,
            IWriteRepository<Grade> writeRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsService)
        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Belge Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Türü", "Açıklama", "Öğrenci", "Dönem" };
            ViewData["CustomProperties"] = new List<string> { "Type", "Description", "StudentFullName", "SemesterName" };
            ViewData["ControllerName"] = "Achievements";
            return base.Get();
        }
        public override async Task<IActionResult> Details(string id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Belge Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Türü", "Açıklama", "Öğrenci", "Dönem" };
            ViewData["CustomProperties"] = new List<string> { "Type", "Description", "StudentFullName", "SemesterName" };
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
