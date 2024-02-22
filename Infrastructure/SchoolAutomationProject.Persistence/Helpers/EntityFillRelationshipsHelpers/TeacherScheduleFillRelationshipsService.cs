using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.TeacherScheduleViewModels;
using SchoolAutomationProject.Application.ViewModels.TeacherViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class TeacherScheduleFillRelationshipsService : ITeacherScheduleFillRelationshipsService
    {
        public TeacherScheduleFillRelationshipsService()
        {

        }

        public Task FillTeacherScheduleRelationships(TeacherSchedule teacherSchedule, WriteTeacherScheduleViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}
