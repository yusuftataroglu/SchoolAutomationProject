using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AnnouncementRepositories;
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
            announcement.AnnouncementRoles.Clear();
            foreach (var roleId in modelVM.AnnouncementRolesRoleIds)
            {
                announcement.AnnouncementRoles.Add(new Domain.Entities.CrossTables.AnnouncementRole { RoleId = roleId });
            }
        }

        public async Task FillAnnouncementRelationshipsForTeacher(Announcement announcement, Application.ViewModels.TeacherAreaViewModels.AnnouncementViewModels.WriteAnnouncementViewModel modelVM, string requestType)
        {
            announcement.AnnouncementRoles.Clear();
            foreach (var roleId in modelVM.AnnouncementRolesRoleIds)
            {
                announcement.AnnouncementRoles.Add(new Domain.Entities.CrossTables.AnnouncementRole { RoleId = roleId });
            }
        }
    }
}

