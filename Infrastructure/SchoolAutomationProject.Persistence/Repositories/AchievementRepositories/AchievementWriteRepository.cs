using SchoolAutomationProject.Application.Repositories.AchievementRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.AchievementRepositories
{
    public class AchievementWriteRepository : WriteRepository<Achievement>, IAchievementWriteRepository
    {
        public AchievementWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
