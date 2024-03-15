using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.ViewModels.ParentAreaViewModels.MessageViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Parent.Controllers
{
    [Area("Parent")]
    [Authorize(Roles ="Parent")]
    public class MessagesController : GenericController<Message,ReadMessageViewModel,WriteMessageViewModel>
    {
        public MessagesController(
            IReadRepository<Message> readRepository,
            IWriteRepository<Message> writeRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsService)
        {
        }


    }
}
