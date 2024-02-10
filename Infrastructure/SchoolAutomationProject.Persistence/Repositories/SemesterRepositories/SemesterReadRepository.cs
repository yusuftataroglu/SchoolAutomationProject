using SchoolAutomationProject.Application.Repositories.SemesterRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.SemesterRepositories
{
    public class SemesterReadRepository : ReadRepository<Semester>, ISemesterReadRepository
    {
        public SemesterReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
