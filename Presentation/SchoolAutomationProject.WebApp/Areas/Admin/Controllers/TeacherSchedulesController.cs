using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Application.Repositories.TeacherScheduleRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherScheduleViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Repositories.TeacherRepositories;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TeacherSchedulesController : GenericController<TeacherSchedule, ReadTeacherScheduleViewModel, WriteTeacherScheduleViewModel>
    {
        private readonly ITeacherScheduleReadRepository _teacherScheduleReadRepository;
        private readonly ITeacherReadRepository _teacherReadRepository;

        public TeacherSchedulesController(
            ITeacherScheduleReadRepository teacherScheduleReadRepository,
            ITeacherScheduleWriteRepository teacherScheduleWriteRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            IMapper mapper,
            ITeacherReadRepository teacherReadRepository)
            : base(teacherScheduleReadRepository, teacherScheduleWriteRepository, mapper, fillEntityRelationshipsService)

        {
            _teacherScheduleReadRepository = teacherScheduleReadRepository;
            _teacherReadRepository = teacherReadRepository;
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Öğretmen Ders Programı Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Tarih ve Saat", "Gün", "Saat", "Sınıf", "Öğretmen" };
            ViewData["CustomProperties"] = new List<string> { "DateTimeShort", "Day", "TimeSlot", "Classroom", "TeacherFullName" };
            ViewData["ControllerName"] = "TeacherSchedules";
            return base.Get();
        }

        [HttpGet]
        public async Task<IActionResult> GetTeacherScheduleTable()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetTeacherScheduleTable(Guid id)
        {
            var teacher = await _teacherReadRepository.GetActiveByIdAsync(id);

            if (teacher != null)
            {
                // Şu anki tarihin haftanın pazartesi günü olduğunu varsayalım
                DateTime dateTime = DateTime.Today;
                DateTime firstDayOfWeek = GetFirstDayOfWeek(dateTime);
                ViewBag.FirstDayOfWeek = firstDayOfWeek.ToShortDateString();
                ViewBag.LastDayOfWeek = firstDayOfWeek.AddDays(4).ToShortDateString();
                var teacherScheduleList = teacher.TeacherSchedules
                    .Where(x => x.IsActive && x.DateTime >= firstDayOfWeek && x.DateTime <= firstDayOfWeek.AddDays(4))
                    .ToList();

                if (teacherScheduleList.Count != 0)
                {
                    return View(teacherScheduleList);
                }
                else
                {
                    TempData["Error"] = "Bu Haftaya Ait Bir Ders Programı Bulunamadı!";
                    return RedirectToAction("Get", "Teachers");
                }
            }
            else
            {
                TempData["Error"] = "Böyle Bir Öğretmen Bulunamadı!";
                return RedirectToAction("Get", "Teachers");
            }
        }


        public DateTime GetFirstDayOfWeek(DateTime dateTime)
        {
            // dateTime parametresi ile gelen tarihin bulunduğu haftanın pazartesi gününün tarihini bulma
            int diff = (7 + (dateTime.DayOfWeek - DayOfWeek.Monday)) % 7;
            return dateTime.AddDays(-1 * diff).Date;
        }

        public override async Task<IActionResult> Details(Guid id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Öğretmen Ders Programı Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Tarih ve Saat", "Gün", "Saat", "Sınıf", "Öğretmen" };
            ViewData["CustomProperties"] = new List<string> { "DateTimeShort", "Day", "TimeSlot", "Classroom", "TeacherFullName" };
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

        public override async Task<IActionResult> Update(Guid id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteTeacherScheduleViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }
    }
}