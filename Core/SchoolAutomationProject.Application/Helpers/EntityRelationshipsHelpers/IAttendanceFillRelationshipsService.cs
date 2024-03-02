using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IAttendanceFillRelationshipsService
    {
        Task FillAttendanceRelationshipsForAdmin(Attendance attendance, ViewModels.AdminAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel modelVM, string requestType);
        Task FillAttendanceRelationshipsForTeacher(Attendance attendance, ViewModels.TeacherAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel modelVM, string requestType);
    }
}
