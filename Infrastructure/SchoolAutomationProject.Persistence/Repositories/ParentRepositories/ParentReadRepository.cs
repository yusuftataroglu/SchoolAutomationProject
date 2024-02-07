using SchoolAutomationProject.Application.Repositories.ParentRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.ParentRepositories
{
    public class ParentReadRepository : ReadRepository<Parent>, IParentReadRepository
    {
        public ParentReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
