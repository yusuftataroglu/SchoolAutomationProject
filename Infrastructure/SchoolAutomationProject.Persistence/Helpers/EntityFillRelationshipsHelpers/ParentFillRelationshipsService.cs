using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.ParentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class ParentFillRelationshipsService : IParentFillRelationshipsService
    {
        public ParentFillRelationshipsService()
        {

        }
        public Task FillParentRelationships(Parent parent, WriteParentViewModel modelVM, string requestType)
        {
            throw new NotImplementedException();
        }
    }
}
