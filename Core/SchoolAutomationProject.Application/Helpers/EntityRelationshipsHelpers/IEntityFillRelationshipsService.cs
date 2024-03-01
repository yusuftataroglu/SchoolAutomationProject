using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IFillEntityRelationshipsService
    {
        public Task FillEntityRelationships<T, TWriteViewModel>(T entity, TWriteViewModel model, string requestType);
    }
}
