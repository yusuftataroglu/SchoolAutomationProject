using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AchievementRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AchievementViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AchievementsController : GenericController<Achievement, ReadAchievementViewModel, WriteAchievementViewModel>
    {
        public AchievementsController(
            IAchievementReadRepository achievementReadRepository,
            IAchievementWriteRepository achievementWriteRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            IMapper mapper)
            : base(achievementReadRepository, achievementWriteRepository, mapper, fillEntityRelationshipsService)

        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Belge Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Türü", "Açıklama", "Öğrenci", "Dönem" };
            ViewData["CustomProperties"] = new List<string> { "Type", "Description","StudentFullName", "SemesterName" };
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

        public override async Task<IActionResult> Add(WriteAchievementViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(string id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteAchievementViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(string id)
        {
            return await base.Delete(id);
        }
    }
}