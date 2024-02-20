using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.TeacherScheduleViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class TeacherScheduleProfile : Profile
    {
        public TeacherScheduleProfile()
        {
            CreateMap<TeacherSchedule, ReadTeacherScheduleViewModel>();
            CreateMap<ReadTeacherScheduleViewModel, TeacherSchedule>();
            CreateMap<TeacherSchedule, WriteTeacherScheduleViewModel>();
            CreateMap<WriteTeacherScheduleViewModel, TeacherSchedule>();
        }
    }
}
