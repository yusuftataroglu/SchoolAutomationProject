using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Application.Helpers.MappingHelpers.Profiles.ClassroomProfile
{
    public class ClassroomProfile : Profile
    {
        public ClassroomProfile()
        {
            CreateMap<Classroom, ReadClassroomViewModel>();       
            CreateMap<WriteClassroomViewModel, Classroom>();       
        }

    }
}
