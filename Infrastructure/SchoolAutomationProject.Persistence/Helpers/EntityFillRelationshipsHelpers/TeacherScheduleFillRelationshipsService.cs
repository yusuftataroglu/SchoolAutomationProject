using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.TeacherRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherScheduleViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class TeacherScheduleFillRelationshipsService : ITeacherScheduleFillRelationshipsService
    {
        private readonly ITeacherReadRepository _teacherReadRepository;

        public TeacherScheduleFillRelationshipsService(ITeacherReadRepository teacherReadRepository)
        {
            _teacherReadRepository = teacherReadRepository;
        }

        public async Task FillTeacherScheduleRelationships(TeacherSchedule teacherSchedule, WriteTeacherScheduleViewModel modelVM, string requestType)
        {
            if (requestType == "Add" || requestType == "UpdatePost")
            {
                teacherSchedule.DateTime = modelVM.DateTime;
                teacherSchedule.Day = modelVM.Day;
                teacherSchedule.TimeSlot = modelVM.TimeSlot;
                teacherSchedule.Classroom = modelVM.Classroom;

                var teacher = await _teacherReadRepository.GetByIdAsync(modelVM.TeacherId);
                if (teacher != null)
                {
                    teacherSchedule.Teacher = teacher;
                }

            }
        }
    }
}
