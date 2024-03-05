using SchoolAutomationProject.Application.Repositories.AdministratorRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.AdministratorRepositories
{
    public class AdministratorWriteRepository : WriteRepository<Administrator>, IAdministratorWriteRepository
    {
        public AdministratorWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
