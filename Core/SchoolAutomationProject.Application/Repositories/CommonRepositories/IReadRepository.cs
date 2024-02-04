using SchoolAutomationProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Application.Repositories.CommonRepositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseClass
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> predicate);//todo expression kaldırılıp denenecek.
        Task<T> GetById(string id);
    }
}
