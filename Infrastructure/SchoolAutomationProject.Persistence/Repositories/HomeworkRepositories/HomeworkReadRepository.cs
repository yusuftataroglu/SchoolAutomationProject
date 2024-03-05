using SchoolAutomationProject.Application.Repositories.HomeworkRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.HomeworkRepositories
{
    public class HomeworkReadRepository : ReadRepository<Homework>, IHomeworkReadRepository
    {
        public HomeworkReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
