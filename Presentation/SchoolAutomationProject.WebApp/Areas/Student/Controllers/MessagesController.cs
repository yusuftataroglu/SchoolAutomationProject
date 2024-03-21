using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.MessageRepositories;
using SchoolAutomationProject.Application.ViewModels.StudentAreaViewModels.MessageViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles ="Student")]
    public class MessagesController : GenericController<Message,ReadMessageViewModel,WriteMessageViewModel>
    {
        private readonly UserManager<AppUser> _userManager;

        public MessagesController(
            IMessageReadRepository messageReadRepository,
            IMessageWriteRepository messageWriteRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            UserManager<AppUser> userManager)
            : base(messageReadRepository, messageWriteRepository, mapper, fillEntityRelationshipsService)
        {
            _userManager = userManager;
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Mesaj Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "İçerik", "Gönderici", "Alıcı"};
            ViewData["CustomProperties"] = new List<string> { "Content", "SenderFullName", "ReceiverFullName" };
            ViewData["ControllerName"] = "Messages";
            return base.Get();
        }
        public override async Task<IActionResult> Details(Guid id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Mesaj Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "İçerik", "Gönderici", "Alıcı" };
            ViewData["CustomProperties"] = new List<string> { "Content", "SenderFullName", "ReceiverFullName" };
            return await base.Details(id);
        }

        public override IActionResult AddByUsername()
        {
            return base.AddByUsername();
        }
        public override async Task<IActionResult> AddByUsername(string userName, WriteMessageViewModel modelVM)
        {
            AppUser user = await _userManager.FindByNameAsync(userName);
            modelVM.SenderId = user.Id;
            return await base.AddByUsername(userName, modelVM);
        }

        public override Task<IActionResult> UpdateByUsername(Guid id)
        {
            return base.UpdateByUsername(id);
        }

        public override async Task<IActionResult> UpdateByUsername(string userName, WriteMessageViewModel modelVM)
        {
            AppUser user = await _userManager.FindByNameAsync(userName);
            modelVM.SenderId = user.Id;
            return await base.UpdateByUsername(userName, modelVM);
        }
        public override async Task<IActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }
    }
}
