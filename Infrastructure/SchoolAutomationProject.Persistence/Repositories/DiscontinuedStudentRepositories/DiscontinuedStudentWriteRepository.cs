using SchoolAutomationProject.Application.Repositories.DiscontinuedStudentRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.DiscontinuedStudentRepositories
{
    public class DiscontinuedStudentWriteRepository : WriteRepository<DiscontinuedStudent>, IDiscontinuedStudentWriteRepository
    {
        public DiscontinuedStudentWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
