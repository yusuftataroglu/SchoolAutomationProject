using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AttendanceViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IAttendanceFillRelationshipsService
    {
        public Task FillAttendanceRelationships(Attendance attendance, WriteAttendanceViewModel modelVM, string requestType);
    }
}
