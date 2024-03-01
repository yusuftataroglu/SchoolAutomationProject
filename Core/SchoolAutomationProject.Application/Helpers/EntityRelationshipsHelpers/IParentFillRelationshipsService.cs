using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ParentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IParentFillRelationshipsService
    {
        public Task FillParentRelationships(Parent parent, WriteParentViewModel modelVM, string requestType);
    }
}
