using Microsoft.EntityFrameworkCore;
using SchoolAutomationProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Application.Repositories.CommonRepositories
{
    public interface IRepository<T> where T : BaseClass
    {
        public DbSet<T> Table { get; }
    }
}
