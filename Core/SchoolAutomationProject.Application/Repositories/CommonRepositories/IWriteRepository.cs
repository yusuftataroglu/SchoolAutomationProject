using SchoolAutomationProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Application.Repositories.CommonRepositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseClass
    {
        Task<bool> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        bool Remove(T entity);
        Task<bool> RemoveByIdAsync(string id);
        bool UpdateAsync(T entity);
        Task<int> SaveChanges();
    }
}
