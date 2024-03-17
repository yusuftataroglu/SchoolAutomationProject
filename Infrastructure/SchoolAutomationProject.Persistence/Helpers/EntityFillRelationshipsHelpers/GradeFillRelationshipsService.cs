using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class GradeFillRelationshipsService : IGradeFillRelationshipsService
    {
        public async Task FillGradeRelationshipsForAdmin(Grade grade, Application.ViewModels.AdminAreaViewModels.GradeViewModels.WriteGradeViewModel modelVM, string requestType)
        {
        }

        public async Task FillGradeRelationshipsForTeacher(Grade grade, Application.ViewModels.TeacherAreaViewModels.GradeViewModels.WriteGradeViewModel modelVM, string requestType)
        {
        }
    }
}

