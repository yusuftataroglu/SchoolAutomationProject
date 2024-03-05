using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class AnnouncementFillRelationshipsService : IAnnouncementFillRelationshipsService
    {

        public AnnouncementFillRelationshipsService()
        {
        }


        public async Task FillAnnouncementRelationshipsForAdmin(Announcement announcement, Application.ViewModels.AdminAreaViewModels.AnnouncementViewModels.WriteAnnouncementViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }

        public async Task FillAnnouncementRelationshipsForTeacher(Announcement announcement, Application.ViewModels.TeacherAreaViewModels.AnnouncementViewModels.WriteAnnouncementViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}

