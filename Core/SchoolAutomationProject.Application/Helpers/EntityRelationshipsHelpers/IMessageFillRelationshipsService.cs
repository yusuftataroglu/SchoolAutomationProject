using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IMessageFillRelationshipsService
    {
        Task FillMessageRelationshipsForAdmin(Message message, ViewModels.AdminAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType);
        Task FillMessageRelationshipsForTeacher(Message message, ViewModels.TeacherAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType);
        Task FillMessageRelationshipsForParent(Message message, ViewModels.ParentAreaViewModels.MessageViewModels.WriteMessageViewModel modelVM, string requestType);
    }
}
