using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.TeacherViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class TeacherScheduleFillRelationshipsService : ITeacherFillRelationshipsService
    {
        public TeacherScheduleFillRelationshipsService()
        {

        }
        public Task FillTeacherRelationships(Teacher teacher, WriteTeacherViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}
