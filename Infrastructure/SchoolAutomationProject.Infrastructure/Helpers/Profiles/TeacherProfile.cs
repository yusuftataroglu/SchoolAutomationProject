using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            CreateMap<Teacher, ReadTeacherViewModel>();
            CreateMap<ReadTeacherViewModel, Teacher>();
            CreateMap<Teacher, WriteTeacherViewModel>();
            CreateMap<WriteTeacherViewModel, Teacher>();
        }
    }
}
