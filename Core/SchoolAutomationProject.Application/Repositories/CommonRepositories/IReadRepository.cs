using SchoolAutomationProject.Domain.Entities.CommonTables;
using System.Linq.Expressions;

namespace SchoolAutomationProject.Application.Repositories.CommonRepositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseClass
    {
        IQueryable<T> GetAllActives();
        IQueryable<T> GetAllPassives();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> predicate);//todo expression kaldırılıp denenecek.
        Task<T> GetAllActivesByIdAsync(Guid? id);
        Task<T> GetAllPassivesByIdAsync(Guid? id);

    }
}
