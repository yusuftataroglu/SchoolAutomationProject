using SchoolAutomationProject.Application.Repositories.DiscontinuedStudentRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.DiscontinuedStudentRepositories
{
    public class DiscontinuedStudentReadRepository : ReadRepository<DiscontinuedStudent>, IDiscontinuedStudentReadRepository
    {
        public DiscontinuedStudentReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
