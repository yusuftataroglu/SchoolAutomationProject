using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipHelpers
{
    public interface IFillEntityRelationshipsService
    {
        public Task FillEntityRelationships<T, TWriteViewModel>(T entity, TWriteViewModel model);
        public Task FillClassroomRelationships(Classroom entity, WriteClassroomViewModel model);
    }
}
