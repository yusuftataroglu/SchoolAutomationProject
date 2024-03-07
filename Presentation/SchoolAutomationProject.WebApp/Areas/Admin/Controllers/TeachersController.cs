using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherViewModels;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TeachersController : GenericController<Domain.Entities.CustomTables.Teacher, ReadTeacherViewModel, WriteTeacherViewModel>
    {

        public TeachersController(
            ITeacherReadRepository readRepository,
            ITeacherWriteRepository writeRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            IMapper mapper)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsService)

        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Öğretmen Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Ad", "Soyad", "Ünvan", "Ana Ders", "Sınıflar", "Programlar" };
            ViewData["CustomProperties"] = new List<string> { "FirstName", "LastName", "Title", "MainCourse", "ClassroomTeachers", "TeacherSchedules" };
            ViewData["ControllerName"] = "Teachers";
            return base.Get();
        }
        public override async Task<IActionResult> Details(Guid id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Öğretmen Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Ad", "Soyad", "Ünvan", "Ana Ders", "Sınıflar", "Programlar" };
            ViewData["CustomProperties"] = new List<string> { "FirstName", "LastName", "Title", "MainCourse", "ClassroomTeachers", "TeacherSchedules" };
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteTeacherViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(Guid id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteTeacherViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }
    }
}

