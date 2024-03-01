using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SubCourseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SubCoursesController : GenericController<SubCourse, ReadSubCourseViewModel, WriteSubCourseViewModel>
    {

        public SubCoursesController(
            ISubCourseReadRepository readRepository,
            ISubCourseWriteRepository writeRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsRepository,
            IMapper mapper)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsRepository)

        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Alt Ders Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Kod", "Haftalık Saat", "Sıra", "Ana Ders" };
            ViewData["CustomProperties"] = new List<string> { "Code", "WeeklyHour", "Position", "MainCourseName" };
            ViewData["ControllerName"] = "SubCourses";
            return base.Get();
        }
        public override async Task<IActionResult> Details(string id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Alt Ders Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Kod", "Haftalık Saat", "Sıra", "Ana Ders" };
            ViewData["CustomProperties"] = new List<string> { "Code", "WeeklyHour", "Position", "MainCourseName" };
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteSubCourseViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(string id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteSubCourseViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(string id)
        {
            return await base.Delete(id);
        }
    }
}