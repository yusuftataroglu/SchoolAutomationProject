using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.DiscontinuedStudentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class DiscontinuedStudentFillRelationshipsService : IDiscontinuedStudentFillRelationshipsService
    {
        public DiscontinuedStudentFillRelationshipsService()
        {
            
        }
        public Task FillDiscontinuedStudentRelationships(DiscontinuedStudent discontinuedStudent, WriteDiscontinuedStudentViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}
