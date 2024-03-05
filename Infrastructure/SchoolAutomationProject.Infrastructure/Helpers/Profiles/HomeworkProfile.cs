using AutoMapper;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class HomeworkProfile:Profile
    {
        public HomeworkProfile()
        {
            CreateMap<Homework, Application.ViewModels.TeacherAreaViewModels.HomeworkViewModels.ReadHomeworkViewModel>();
            CreateMap<Application.ViewModels.TeacherAreaViewModels.HomeworkViewModels.ReadHomeworkViewModel, Homework>();
            CreateMap<Homework, Application.ViewModels.TeacherAreaViewModels.HomeworkViewModels.WriteHomeworkViewModel>();
            CreateMap<Application.ViewModels.TeacherAreaViewModels.HomeworkViewModels.WriteHomeworkViewModel, Homework>();

            CreateMap<Homework, Application.ViewModels.StudentAreaViewModels.HomeworkViewModels.ReadHomeworkViewModel>();
            CreateMap<Application.ViewModels.StudentAreaViewModels.HomeworkViewModels.ReadHomeworkViewModel, Homework>();
            CreateMap<Homework, Application.ViewModels.StudentAreaViewModels.HomeworkViewModels.WriteHomeworkViewModel>();
            CreateMap<Application.ViewModels.StudentAreaViewModels.HomeworkViewModels.WriteHomeworkViewModel, Homework>();
        }
    }
}
