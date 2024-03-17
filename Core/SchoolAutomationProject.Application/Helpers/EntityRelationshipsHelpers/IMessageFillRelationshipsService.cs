using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IMessageFillRelationshipsService
    {
        void FillMessageRelationshipsForAdmin(Message message, ViewModels.AdminAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType);
        void FillMessageRelationshipsForTeacher(Message message, ViewModels.TeacherAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType);
        void FillMessageRelationshipsForParent(Message message, ViewModels.ParentAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType);
    }
}
