using SchoolAutomationProject.Application.Repositories.AchievementRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.AchievementRepositories
{
    public class AchievementReadRepository : ReadRepository<Achievement>, IAchievementReadRepository
    {
        public AchievementReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
