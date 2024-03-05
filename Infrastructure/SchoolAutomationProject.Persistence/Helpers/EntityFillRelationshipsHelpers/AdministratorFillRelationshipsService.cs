using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AdministratorViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class AdministratorFillRelationshipsService : IAdministratorFillRelationshipsService
    {

        public AdministratorFillRelationshipsService()
        {
        }

        public async Task FillAdministratorRelationships(Administrator admin, WriteAdministratorViewModel modelVM, string requestType)
        {

            if (requestType == "Add" || requestType == "UpdatePost")
            {

            }

        }
    }
}

