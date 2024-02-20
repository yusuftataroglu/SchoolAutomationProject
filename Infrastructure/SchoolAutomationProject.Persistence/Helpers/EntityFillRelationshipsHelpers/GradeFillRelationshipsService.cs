using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.GradeViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class GradeFillRelationshipsService : IGradeFillRelationshipsService
    {
        public GradeFillRelationshipsService()
        {

        }
        public Task FillGradeRelationships(Grade grade, WriteGradeViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}
