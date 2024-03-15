using Microsoft.EntityFrameworkCore;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Persistence.Contexts;
using System.Linq.Expressions;

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
            => Table.Where(x=> x.IsActive); //DbSet IQueryable'ı implement ediyor. O yüzden DbSet döndürebiliyoruz.

        public async Task<T> GetByIdAsync(Guid? id)
            => await Table.FindAsync(id);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
            => Table.Where(predicate);
    }
}
