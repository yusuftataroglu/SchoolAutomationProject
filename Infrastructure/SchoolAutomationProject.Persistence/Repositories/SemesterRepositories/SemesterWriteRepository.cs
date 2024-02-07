using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.SemesterRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.SemesterRepositories
{
    public class SemesterWriteRepository : WriteRepository<Semester>, ISemesterWriteRepository
    {
        public SemesterWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
