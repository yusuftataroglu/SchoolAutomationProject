using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.Application.Repositories.CommonRepositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseClass
    {
        Task<bool> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        void Remove(T entity);
        Task RemoveByIdAsync(Guid id);
        bool Update<TWriteViewModel>(T entity, TWriteViewModel modelVM);
        Task SaveChangesAsync();
    }
}
