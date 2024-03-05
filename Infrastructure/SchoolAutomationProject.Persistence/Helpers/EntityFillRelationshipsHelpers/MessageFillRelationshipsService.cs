using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class MessageFillRelationshipsService : IMessageFillRelationshipsService
    {

        public MessageFillRelationshipsService()
        {
        }

        public Task FillMessageRelationshipsForAdmin(Message message, Application.ViewModels.AdminAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }

        public Task FillMessageRelationshipsForParent(Message message, Application.ViewModels.ParentAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }

        public Task FillMessageRelationshipsForTeacher(Message message, Application.ViewModels.TeacherAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}

