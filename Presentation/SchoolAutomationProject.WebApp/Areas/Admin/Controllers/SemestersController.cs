using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.SemesterRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SemesterViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SemestersController : GenericController<Semester, ReadSemesterViewModel, WriteSemesterViewModel>
    {

        public SemestersController(
            ISemesterReadRepository readRepository,
            ISemesterWriteRepository writeRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsRepository,
            IMapper mapper)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsRepository)

        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Dönem Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Dönem Adı", "Başlangıç Tarihi", "Bitiş Tarihi" };
            ViewData["CustomProperties"] = new List<string> { "Name", "StartDateShort", "EndDateShort" };
            ViewData["ControllerName"] = "Semesters";
            return base.Get();
        }
        public override async Task<IActionResult> Details(string id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Dönem Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Dönem Adı", "Başlangıç Tarihi", "Bitiş Tarihi" };
            ViewData["CustomProperties"] = new List<string> { "Name", "StartDateShort", "EndDateShort" };
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteSemesterViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(string id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteSemesterViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(string id)
        {
            return await base.Delete(id);
        }
    }
}