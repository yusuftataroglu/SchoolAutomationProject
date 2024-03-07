using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ClassroomsController : GenericController<Classroom, ReadClassroomViewModel, WriteClassroomViewModel>
    {

        public ClassroomsController(
            IClassroomReadRepository readRepository,
            IClassroomWriteRepository writeRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            IMapper mapper)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsService)

        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Sınıf Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Sınıf", "Kapasite", "Verilen Dersler", "Öğrenciler", "Öğretmenler" };
            ViewData["CustomProperties"] = new List<string> { "Name", "Capacity", "ClassroomMainCourses", "Students", "ClassroomTeachers" };
            ViewData["ControllerName"] = "Classrooms";

            return base.Get();
        }
        public override async Task<IActionResult> Details(Guid id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Sınıf Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Sınıf", "Kapasite", "Verilen Dersler", "Öğrenciler", "Öğretmenler" };
            ViewData["CustomProperties"] = new List<string> { "Name", "Capacity", "ClassroomMainCourses", "Students", "ClassroomTeachers" };
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteClassroomViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(Guid id)
        {
            return await base.Update(id);
        }

        
        public override async Task<IActionResult> Update(WriteClassroomViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }
    }
}