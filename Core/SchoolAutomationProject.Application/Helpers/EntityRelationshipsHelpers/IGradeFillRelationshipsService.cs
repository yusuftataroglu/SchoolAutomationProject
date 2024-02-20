using SchoolAutomationProject.Application.ViewModels.GradeViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IGradeFillRelationshipsService
    {
        public Task FillGradeRelationships(Grade grade, WriteGradeViewModel modelVM, string requestType);
    }
}
