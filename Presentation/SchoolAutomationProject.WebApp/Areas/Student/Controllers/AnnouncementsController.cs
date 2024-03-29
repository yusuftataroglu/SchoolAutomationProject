using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AnnouncementRepositories;
using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Application.ViewModels.StudentAreaViewModels.AnnouncementViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class AnnouncementsController : GenericController<Announcement, ReadAnnouncementViewModel, IWriteViewModel>
    {
        private readonly IAnnouncementReadRepository _announcementReadRepository;
        private readonly IMapper _mapper;
        private readonly RoleManager<AppUserRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public AnnouncementsController(
            IAnnouncementReadRepository announcementReadRepository,
            IAnnouncementWriteRepository announcementWriteRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            RoleManager<AppUserRole> roleManager,
            UserManager<AppUser> userManager)
            : base(announcementReadRepository, announcementWriteRepository, mapper, fillEntityRelationshipsService)
        {
            _announcementReadRepository = announcementReadRepository;
            _mapper = mapper;
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Duyuru Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Duyuru Başlığı", "Gönderen", "Gönderilenler" };
            ViewData["CustomProperties"] = new List<string> { "Title", "Sender", "AnnouncementRoles" };
            ViewData["ControllerName"] = "Announcements";
            return base.Get();
        }

        public override Task<IActionResult> Details(Guid id)
        {
            return base.Details(id);
        }
    }
}
