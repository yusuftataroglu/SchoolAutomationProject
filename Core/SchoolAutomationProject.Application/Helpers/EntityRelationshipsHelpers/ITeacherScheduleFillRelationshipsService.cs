using SchoolAutomationProject.Application.ViewModels.TeacherScheduleViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface ITeacherScheduleFillRelationshipsService
    {
        public Task FillTeacherScheduleRelationships(TeacherSchedule teacherSchedule, WriteTeacherScheduleViewModel modelVM, string requestType);
    }
}
