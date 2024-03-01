using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.DiscontinuedStudentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class DiscontinuedStudentProfile : Profile
    {
        public DiscontinuedStudentProfile()
        {
            CreateMap<DiscontinuedStudent, ReadDiscontinuedStudentViewModel>();
            CreateMap<ReadDiscontinuedStudentViewModel, DiscontinuedStudent>();
            CreateMap<DiscontinuedStudent, WriteDiscontinuedStudentViewModel>();
            CreateMap<WriteDiscontinuedStudentViewModel, DiscontinuedStudent>();
        }
    }
}
