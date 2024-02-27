using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.TeacherScheduleRepositories;
using SchoolAutomationProject.Application.ViewModels.TeacherScheduleViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TeacherSchedulesController : GenericController<TeacherSchedule, ReadTeacherScheduleViewModel, WriteTeacherScheduleViewModel>
    {

        public TeacherSchedulesController(
            ITeacherScheduleReadRepository readRepository,
            ITeacherScheduleWriteRepository writeRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsRepository,
            IMapper mapper)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsRepository)

        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Öğretmen Ders Programı Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Tarih ve Saat", "Gün", "Zaman Aralığı", "Sınıf", "Öğretmen" };
            ViewData["CustomProperties"] = new List<string> { "DateTime", "Day", "TimeSlot", "Classroom", "TeacherFullName" };
            ViewData["ControllerName"] = "TeacherSchedules";
            return base.Get();
        }
        public override async Task<IActionResult> Details(string id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Öğretmen Ders Programı Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Tarih ve Saat", "Gün", "Zaman Aralığı", "Sınıf", "Öğretmen" };
            ViewData["CustomProperties"] = new List<string> { "DateTime", "Day", "TimeSlot", "Classroom", "TeacherFullName" };
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteTeacherScheduleViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(string id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteTeacherScheduleViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(string id)
        {
            return await base.Delete(id);
        }
    }
}