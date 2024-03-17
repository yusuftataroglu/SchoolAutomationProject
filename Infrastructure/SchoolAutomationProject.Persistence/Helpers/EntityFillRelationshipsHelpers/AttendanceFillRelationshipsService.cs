using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class AttendanceFillRelationshipsService : IAttendanceFillRelationshipsService
    {
        public async Task FillAttendanceRelationshipsForAdmin(Attendance attendance, Application.ViewModels.AdminAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel modelVM, string requestType)
        {
        }

        public async Task FillAttendanceRelationshipsForTeacher(Attendance attendance, Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel modelVM, string requestType)
        {
        }
    }
}
