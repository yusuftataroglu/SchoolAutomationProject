using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.GradeViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class GradeProfile : Profile
    {
        public GradeProfile()
        {
            CreateMap<Grade, ReadGradeViewModel>();
            CreateMap<ReadGradeViewModel, Grade>();
            CreateMap<Grade, WriteGradeViewModel>();
            CreateMap<WriteGradeViewModel, Grade>();
        }
    }
}
