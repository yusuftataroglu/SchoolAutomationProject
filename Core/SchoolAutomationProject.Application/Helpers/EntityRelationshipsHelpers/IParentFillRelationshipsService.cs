using SchoolAutomationProject.Application.ViewModels.ParentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IParentFillRelationshipsService
    {
        public void FillParentRelationships(Parent parent, WriteParentViewModel modelVM, string requestType);
    }
}
