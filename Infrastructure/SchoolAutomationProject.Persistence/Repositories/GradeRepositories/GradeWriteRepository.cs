using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.GradeRepositories
{
    public class GradeWriteRepository : WriteRepository<Grade>, IGradeWriteRepository
    {
        public GradeWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
