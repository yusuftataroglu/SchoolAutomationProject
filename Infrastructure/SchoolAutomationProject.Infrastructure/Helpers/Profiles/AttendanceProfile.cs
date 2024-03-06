using AutoMapper;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Infrastructure.Helpers.Profiles
{
    public class AttendanceProfile : Profile
    {
        public AttendanceProfile()
        {
            CreateMap<Attendance, Application.ViewModels.AdminAreaViewModels.AttendanceViewModels.ReadAttendanceViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.AttendanceViewModels.ReadAttendanceViewModel, Attendance>();
            CreateMap<Attendance, Application.ViewModels.AdminAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel>();
            CreateMap<Application.ViewModels.AdminAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel, Attendance>();

            CreateMap<Attendance, Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels.ReadAttendanceViewModel>();
            CreateMap<Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels.ReadAttendanceViewModel, Attendance>();
            CreateMap<Attendance, Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel>();
            CreateMap<Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel, Attendance>();

            CreateMap<Attendance, Application.ViewModels.StudentAreaViewModels.AttendanceViewModels.ReadAttendanceViewModel>();
            CreateMap<Application.ViewModels.StudentAreaViewModels.AttendanceViewModels.ReadAttendanceViewModel, Attendance>();

            CreateMap<Attendance, Application.ViewModels.ParentAreaViewModels.AttendanceViewModels.ReadAttendanceViewModel>();
            CreateMap<Application.ViewModels.ParentAreaViewModels.AttendanceViewModels.ReadAttendanceViewModel, Attendance>();
        }
    }
}
