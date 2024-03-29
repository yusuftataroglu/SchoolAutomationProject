using AutoMapper;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class GradeProfile : Profile
    {
        public GradeProfile()
        {
            CreateMap<Grade, Application.ViewModels.AdminAreaViewModels.GradeViewModels.ReadGradeViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.GradeViewModels.ReadGradeViewModel, Grade>();
            CreateMap<Grade, Application.ViewModels.AdminAreaViewModels.GradeViewModels.WriteGradeViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.GradeViewModels.WriteGradeViewModel, Grade>();

            CreateMap<Grade, Application.ViewModels.TeacherAreaViewModels.GradeViewModels.ReadGradeViewModel>();
            CreateMap<Application.ViewModels.TeacherAreaViewModels.GradeViewModels.ReadGradeViewModel, Grade>();
            CreateMap<Grade, Application.ViewModels.TeacherAreaViewModels.GradeViewModels.WriteGradeViewModel>();
            CreateMap<Application.ViewModels.TeacherAreaViewModels.GradeViewModels.WriteGradeViewModel, Grade>();

            CreateMap<Grade, Application.ViewModels.StudentAreaViewModels.GradeViewModels.ReadGradeViewModel>();
            CreateMap<Application.ViewModels.StudentAreaViewModels.GradeViewModels.ReadGradeViewModel, Grade>();

            CreateMap<Grade, Application.ViewModels.ParentAreaViewModels.GradeViewModels.ReadGradeViewModel>();
            CreateMap<Application.ViewModels.ParentAreaViewModels.GradeViewModels.ReadGradeViewModel, Grade>();
        }
    }
}
