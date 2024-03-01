using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AchievementViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class AchievementProfile:Profile
    {
        public AchievementProfile()
        {
            CreateMap<Achievement,ReadAchievementViewModel>();
            CreateMap<ReadAchievementViewModel, Achievement>();
            CreateMap<Achievement, WriteAchievementViewModel>();
            CreateMap<WriteAchievementViewModel, Achievement>();
        }
    }
}
