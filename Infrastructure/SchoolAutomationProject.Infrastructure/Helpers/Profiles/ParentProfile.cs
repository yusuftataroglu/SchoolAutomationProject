using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.ParentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class ParentProfile : Profile
    {
        public ParentProfile()
        {
            CreateMap<Parent, ReadParentViewModel>();
            CreateMap<ReadParentViewModel, Parent>();
            CreateMap<Parent, WriteParentViewModel>();
            CreateMap<WriteParentViewModel, Parent>();
        }
    }
}
