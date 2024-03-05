using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IAnnouncementFillRelationshipsService
    {
        Task FillAnnouncementRelationshipsForAdmin(Announcement announcement, ViewModels.AdminAreaViewModels.AnnouncementViewModels.WriteAnnouncementViewModel modelVM, string requestType);
        Task FillAnnouncementRelationshipsForTeacher(Announcement announcement, ViewModels.TeacherAreaViewModels.AnnouncementViewModels.WriteAnnouncementViewModel modelVM, string requestType);
    }
}
