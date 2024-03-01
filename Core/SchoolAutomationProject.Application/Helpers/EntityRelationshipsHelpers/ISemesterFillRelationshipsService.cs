using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SemesterViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface ISemesterFillRelationshipsService
    {
        public Task FillSemesterRelationships(Semester semester, WriteSemesterViewModel modelVM, string requestType);
    }
}
