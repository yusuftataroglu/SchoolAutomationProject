using SchoolAutomationProject.Application.ViewModels.TeacherViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface ITeacherFillRelationshipsService
    {
        public Task FillTeacherRelationships(Teacher teacher, WriteTeacherViewModel modelVM, string requestType);
    }
}
