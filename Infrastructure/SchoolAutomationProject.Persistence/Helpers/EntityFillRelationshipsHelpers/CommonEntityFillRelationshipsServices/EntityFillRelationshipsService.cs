using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.ClassroomFillRelationshipsServices;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.CommonEntityFillRelationshipsServices;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.MainCourseFillRelationshipsServices;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.TeacherFillRelationshipsServices;
using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Application.ViewModels.MainCourseViewModels;
using SchoolAutomationProject.Application.ViewModels.TeacherViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers.CommonEntityFillRelationshipsServices
{
    public class FillEntityRelationshipsService : IFillEntityRelationshipsService
    {
        private readonly IClassroomFillRelationshipsService _classroomFillRelationshipsService;
        private readonly ITeacherFillRelationshipsService _teacherFillRelationshipsService;
        private readonly IMainCourseFillRelationshipsService _mainCourseFillRelationshipsService;

        public FillEntityRelationshipsService(
            IClassroomFillRelationshipsService classroomFillRelationshipsService,
            ITeacherFillRelationshipsService teacherFillRelationshipsService,
            IMainCourseFillRelationshipsService mainCourseFillRelationshipsService)
        {
            _classroomFillRelationshipsService = classroomFillRelationshipsService;
            _teacherFillRelationshipsService = teacherFillRelationshipsService;
            _mainCourseFillRelationshipsService = mainCourseFillRelationshipsService;
        }

        public async Task FillEntityRelationships<T, TWriteViewModel>(T entity, TWriteViewModel modelVM, string requestType)
        {
            if (typeof(T) == typeof(Classroom))
            {
                await _classroomFillRelationshipsService.FillClassroomRelationships(entity as Classroom, modelVM as WriteClassroomViewModel, requestType);
            }
            else if (typeof(T) == typeof(Teacher))
            {
                await _teacherFillRelationshipsService.FillTeacherRelationships(entity as Teacher, modelVM as WriteTeacherViewModel, requestType);
            }
            else if (typeof(T) == typeof(MainCourse))
            {
                await _mainCourseFillRelationshipsService.FillMainCourseRelationships(entity as MainCourse, modelVM as WriteMainCourseViewModel, requestType);
            }
        }

    }
}

