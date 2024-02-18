using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class ClassroomProfile : Profile
    {
        public ClassroomProfile()
        {
            CreateMap<Classroom, ReadClassroomViewModel>();
            CreateMap<ReadClassroomViewModel, Classroom>();
            CreateMap<Classroom, WriteClassroomViewModel>();
            CreateMap<WriteClassroomViewModel, Classroom>();
        }

    }
}
