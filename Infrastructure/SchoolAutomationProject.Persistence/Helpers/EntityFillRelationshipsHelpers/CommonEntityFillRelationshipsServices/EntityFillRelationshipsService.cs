using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.ClassroomFillRelationshipsServices;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.CommonEntityFillRelationshipsServices;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.TeacherFillRelationshipsServices;
using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Application.ViewModels.TeacherViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers.CommonEntityFillRelationshipsServices
{
    public class FillEntityRelationshipsService : IFillEntityRelationshipsService
    {
        private readonly IClassroomFillRelationshipsService _classroomFillRelationshipsService;
        private readonly ITeacherFillRelationshipsService _teacherFillRelationshipsService;

        public FillEntityRelationshipsService(
            IClassroomFillRelationshipsService classroomFillRelationshipsService,
            ITeacherFillRelationshipsService teacherFillRelationshipsService)
        {
            _classroomFillRelationshipsService = classroomFillRelationshipsService;
            _teacherFillRelationshipsService = teacherFillRelationshipsService;
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
        }

    }
}

