using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
