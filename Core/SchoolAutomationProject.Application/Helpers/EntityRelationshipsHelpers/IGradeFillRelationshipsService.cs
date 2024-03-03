using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IGradeFillRelationshipsService
    {
        Task FillGradeRelationshipsForAdmin(Grade grade, ViewModels.AdminAreaViewModels.GradeViewModels.WriteGradeViewModel modelVM, string requestType);
        Task FillGradeRelationshipsForTeacher(Grade grade, ViewModels.TeacherAreaViewModels.GradeViewModels.WriteGradeViewModel modelVM, string requestType);
    }
}
