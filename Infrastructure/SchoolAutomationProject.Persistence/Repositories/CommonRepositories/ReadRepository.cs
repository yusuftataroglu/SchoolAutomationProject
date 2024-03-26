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

        public IQueryable<T> GetAllActives()
            => Table.Where(x => x.IsActive); //DbSet IQueryable'ı implement ediyor. O yüzden DbSet döndürebiliyoruz.
        public IQueryable<T> GetAllPassives()
            => Table.Where(x => x.IsActive == false);

        public async Task<T> GetActiveByIdAsync(Guid? id)
            => await Table.Where(x => x.Id == id && x.IsActive == true).FirstOrDefaultAsync();

        public async Task<T> GetPassiveByIdAsync(Guid? id)
            => await Table.Where(x => x.Id == id && x.IsActive == false).FirstOrDefaultAsync();


        public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate)
            => Table.Where(predicate);

    }
}
