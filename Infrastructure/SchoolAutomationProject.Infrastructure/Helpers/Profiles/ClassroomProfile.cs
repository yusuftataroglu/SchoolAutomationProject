using AutoMapper;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class ClassroomProfile : Profile
    {
        public ClassroomProfile()
        {
            CreateMap<Classroom, Application.ViewModels.AdminAreaViewModels.ClassroomViewModels.ReadClassroomViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.ClassroomViewModels.ReadClassroomViewModel, Classroom>();
            CreateMap<Classroom, Application.ViewModels.AdminAreaViewModels.ClassroomViewModels.WriteClassroomViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.ClassroomViewModels.WriteClassroomViewModel, Classroom>();


            CreateMap<Classroom, Application.ViewModels.TeacherAreaViewModels.ClassroomViewModels.ReadClassroomViewModel>();
            CreateMap<Application.ViewModels.TeacherAreaViewModels.ClassroomViewModels.ReadClassroomViewModel, Classroom>();

        }

    }
}
