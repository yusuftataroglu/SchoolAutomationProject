using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class ClassroomProfile : Profile
    {
        public ClassroomProfile()
        {
            CreateMap<Classroom, ReadClassroomViewModel>();
            CreateMap<ReadClassroomViewModel, Classroom>();
            CreateMap<Classroom, WriteClassroomViewModel>();
            CreateMap<WriteClassroomViewModel, Classroom>();

        }

    }
}
