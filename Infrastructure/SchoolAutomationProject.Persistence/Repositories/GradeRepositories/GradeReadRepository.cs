using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.GradeRepositories
{
    public class GradeReadRepository : ReadRepository<Grade>, IGradeReadRepository
    {
        public GradeReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
