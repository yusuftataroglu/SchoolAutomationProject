using AutoMapper;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, Application.ViewModels.AdminAreaViewModels.StudentViewModels.ReadStudentViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.StudentViewModels.ReadStudentViewModel, Student>();
            CreateMap<Student, Application.ViewModels.AdminAreaViewModels.StudentViewModels.WriteStudentViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.StudentViewModels.WriteStudentViewModel, Student>();
        }
    }
}
