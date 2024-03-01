using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.StudentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IStudentFillRelationshipsService
    {
        public Task FillStudentRelationships(Student student, WriteStudentViewModel modelVM, string requestType);
    }
}
