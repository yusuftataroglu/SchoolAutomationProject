using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
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
            CreateMap<WriteClassroomViewModel, Classroom>()
                .ForMember(x => x.CreatedDate, option => option.Ignore())
                .ForMember(x => x.CreatedComputerName, option => option.Ignore())
                .ForMember(x => x.CreatedIpAddress, option => option.Ignore());

        }

    }
}
