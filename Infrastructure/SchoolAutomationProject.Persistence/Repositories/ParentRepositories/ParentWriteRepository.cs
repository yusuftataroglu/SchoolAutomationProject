using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.ParentRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.ParentRepositories
{
    public class ParentWriteRepository : WriteRepository<Parent>, IParentWriteRepository
    {
        public ParentWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
