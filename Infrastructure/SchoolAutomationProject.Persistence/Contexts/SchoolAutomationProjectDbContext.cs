using Microsoft.EntityFrameworkCore;

namespace SchoolAutomationProject.Persistence.Contexts
{
    public class SchoolAutomationProjectDbContext:DbContext //todo identity eklenebilir!
    {
        public SchoolAutomationProjectDbContext()
        {
            
        }

        public SchoolAutomationProjectDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
