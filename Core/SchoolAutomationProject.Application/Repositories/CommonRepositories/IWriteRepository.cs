using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.Application.Repositories.CommonRepositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseClass
    {
        Task<bool> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        bool Remove(T entity);
        Task<bool> RemoveByIdAsync(string id);
        bool Update(T entity);
        Task SaveChangesAsync();
    }
}
