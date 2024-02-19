using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.CommonEntityFillRelationshipsServices
{
    public interface IFillEntityRelationshipsService
    {
        public Task FillEntityRelationships<T, TWriteViewModel>(T entity, TWriteViewModel model, string requestType);
    }
}
