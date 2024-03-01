using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SubCourseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class SubCourseProfile : Profile
    {
        public SubCourseProfile()
        {
            CreateMap<SubCourse, ReadSubCourseViewModel>();
            CreateMap<ReadSubCourseViewModel, SubCourse>();
            CreateMap<SubCourse, WriteSubCourseViewModel>();
            CreateMap<WriteSubCourseViewModel, SubCourse>();
        }
    }
}
