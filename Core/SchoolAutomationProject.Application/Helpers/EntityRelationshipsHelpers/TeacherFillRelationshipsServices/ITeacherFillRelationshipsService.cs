using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Application.ViewModels.TeacherViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.TeacherFillRelationshipsServices
{
    public interface ITeacherFillRelationshipsService
    {
        public Task FillTeacherRelationships(Teacher teacher, WriteTeacherViewModel modelVM, string requestType);
    }
}
