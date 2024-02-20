using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.AttendanceViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class AttendanceFillRelationshipsService : IAttendanceFillRelationshipsService
    {
        public AttendanceFillRelationshipsService()
        {

        }
        public Task FillAttendanceRelationships(Attendance attendance, WriteAttendanceViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}
