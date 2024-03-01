using AutoMapper;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AttendanceViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class AttendanceProfile : Profile
    {
        public AttendanceProfile()
        {
            CreateMap<Attendance, ReadAttendanceViewModel>();
            CreateMap<ReadAttendanceViewModel, Attendance>();
            CreateMap<Attendance, WriteAttendanceViewModel>();
            CreateMap<WriteAttendanceViewModel, Attendance>();
        }
    }
}
