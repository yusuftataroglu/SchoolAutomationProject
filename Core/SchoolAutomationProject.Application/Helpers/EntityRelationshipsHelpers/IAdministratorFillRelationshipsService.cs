using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IAdministratorFillRelationshipsService
    {
        Task FillAdministratorRelationships(Administrator admin, ViewModels.AdminAreaViewModels.AdministratorViewModels.WriteAdministratorViewModel modelVM, string requestType);
    }
}
