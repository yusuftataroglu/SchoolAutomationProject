using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.SemesterViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class SemesterProfile : Profile
    {
        public SemesterProfile()
        {
            CreateMap<Semester, ReadSemesterViewModel>();
            CreateMap<ReadSemesterViewModel, Semester>();
            CreateMap<Semester, WriteSemesterViewModel>();
            CreateMap<WriteSemesterViewModel, Semester>();
        }
    }
}
