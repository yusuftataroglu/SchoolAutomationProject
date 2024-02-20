using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.MainCourseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class MainCourseProfile:Profile
    {
        public MainCourseProfile()
        {
            CreateMap<MainCourse, ReadMainCourseViewModel>();
            CreateMap<ReadMainCourseViewModel, MainCourse>();
            CreateMap<MainCourse, WriteMainCourseViewModel>();
            CreateMap<WriteMainCourseViewModel, MainCourse>();

        }
    }
}
