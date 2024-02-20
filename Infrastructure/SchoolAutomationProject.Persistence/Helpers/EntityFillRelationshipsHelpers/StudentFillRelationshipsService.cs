using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.StudentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class StudentFillRelationshipsService : IStudentFillRelationshipsService
    {
        public StudentFillRelationshipsService()
        {

        }
        public Task FillStudentRelationships(Student student, WriteStudentViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}
