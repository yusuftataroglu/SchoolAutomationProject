using SchoolAutomationProject.Application.Repositories.AnnouncementRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.AnnouncementRepositories
{
    public class AnnouncementReadRepository : ReadRepository<Announcement>, IAnnouncementReadRepository
    {
        public AnnouncementReadRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
