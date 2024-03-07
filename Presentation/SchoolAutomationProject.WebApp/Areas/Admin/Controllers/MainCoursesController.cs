using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.MainCourseRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.MainCourseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MainCoursesController : GenericController<MainCourse, ReadMainCourseViewModel, WriteMainCourseViewModel>
    {
        public MainCoursesController(
            IMainCourseReadRepository readRepository,
            IMainCourseWriteRepository writeRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsService)
        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Ana Ders Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Ana Ders", "Alt Dersler", "Öğretmenler", "Sınıflar" };
            ViewData["CustomProperties"] = new List<string> { "Name", "SubCourses", "Teachers", "ClassroomMainCourses" };
            ViewData["ControllerName"] = "MainCourses";
            return base.Get();
        }
        public override async Task<IActionResult> Details(Guid id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Ana Ders Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Ana Ders", "Alt Dersler", "Öğretmenler", "Sınıflar" };
            ViewData["CustomProperties"] = new List<string> { "Name", "SubCourses", "Teachers", "ClassroomMainCourses" };
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteMainCourseViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(Guid id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteMainCourseViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }
    }
}
