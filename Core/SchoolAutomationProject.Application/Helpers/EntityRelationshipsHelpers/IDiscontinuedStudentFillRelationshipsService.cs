using SchoolAutomationProject.Application.ViewModels.DiscontinuedStudentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IDiscontinuedStudentFillRelationshipsService
    {
        public Task FillDiscontinuedStudentRelationships(DiscontinuedStudent discontinuedStudent, WriteDiscontinuedStudentViewModel modelVM, string requestType);
    }
}
