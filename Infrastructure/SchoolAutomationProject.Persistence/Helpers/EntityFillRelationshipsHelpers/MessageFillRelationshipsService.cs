using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class MessageFillRelationshipsService : IMessageFillRelationshipsService
    {
        public void FillMessageRelationshipsForAdmin(Message message, Application.ViewModels.AdminAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType)
        {
        }

        public void FillMessageRelationshipsForParent(Message message, Application.ViewModels.ParentAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType)
        {
        }

        public void FillMessageRelationshipsForTeacher(Message message, Application.ViewModels.TeacherAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType)
        {
        }
    }
}

