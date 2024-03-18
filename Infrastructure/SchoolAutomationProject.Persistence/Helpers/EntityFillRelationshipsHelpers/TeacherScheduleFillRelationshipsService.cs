using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherScheduleViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class TeacherScheduleFillRelationshipsService : ITeacherScheduleFillRelationshipsService
    {
        public async Task FillTeacherScheduleRelationships(TeacherSchedule teacherSchedule, WriteTeacherScheduleViewModel modelVM, string requestType)
        {
            teacherSchedule.Day = teacherSchedule.DateTime.DayOfWeek;
        }
    }
}
