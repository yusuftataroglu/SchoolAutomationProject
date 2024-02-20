using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.SemesterViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class SemesterFillRelationshipsService : ISemesterFillRelationshipsService
    {
        public SemesterFillRelationshipsService()
        {

        }
        public Task FillSemesterRelationships(Semester semester, WriteSemesterViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}
