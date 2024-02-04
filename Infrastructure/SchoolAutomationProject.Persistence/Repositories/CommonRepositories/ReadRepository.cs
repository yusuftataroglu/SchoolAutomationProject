using Microsoft.EntityFrameworkCore;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Domain.Entities.Common;
using SchoolAutomationProject.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Persistence.Repositories.CommonRepositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseClass
    {
        private readonly SchoolAutomationProjectDbContext _context;

        public ReadRepository(SchoolAutomationProjectDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table; //DbSet IQueryable'ı implement ediyor. O yüzden DbSet döndürebiliyoruz.

        public async Task<T> GetById(string id)
            => await Table.FirstOrDefaultAsync(entity => entity.Id.ToString() == id);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
            => Table.Where(predicate);
    }
}
