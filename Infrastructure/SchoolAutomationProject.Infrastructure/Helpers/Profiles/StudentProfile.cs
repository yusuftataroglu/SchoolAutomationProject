using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.StudentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, ReadStudentViewModel>();
            CreateMap<ReadStudentViewModel, Student>();
            CreateMap<Student, WriteStudentViewModel>();
            CreateMap<WriteStudentViewModel, Student>();
        }
    }
}
