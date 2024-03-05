using AutoMapper;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class AnnouncementProfile:Profile
    {
        public AnnouncementProfile()
        {
            CreateMap<Announcement, Application.ViewModels.AdminAreaViewModels.AnnouncementViewModels.ReadAnnouncementViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.AnnouncementViewModels.ReadAnnouncementViewModel, Announcement>();
            CreateMap<Announcement, Application.ViewModels.AdminAreaViewModels.AnnouncementViewModels.WriteAnnouncementViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.AnnouncementViewModels.WriteAnnouncementViewModel, Announcement>();

            CreateMap<Announcement, Application.ViewModels.TeacherAreaViewModels.AnnouncementViewModels.ReadAnnouncementViewModel>();
            CreateMap<Application.ViewModels.TeacherAreaViewModels.AnnouncementViewModels.ReadAnnouncementViewModel, Announcement>();
            CreateMap<Announcement, Application.ViewModels.TeacherAreaViewModels.AnnouncementViewModels.WriteAnnouncementViewModel>();
            CreateMap<Application.ViewModels.TeacherAreaViewModels.AnnouncementViewModels.WriteAnnouncementViewModel, Announcement>();
        }
    }
}
