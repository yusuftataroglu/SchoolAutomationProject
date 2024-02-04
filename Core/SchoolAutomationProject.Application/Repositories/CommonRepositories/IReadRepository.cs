﻿using SchoolAutomationProject.Domain.Entities.Common;
using System.Linq.Expressions;

namespace SchoolAutomationProject.Application.Repositories.CommonRepositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseClass
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> predicate);//todo expression kaldırılıp denenecek.
        Task<T> GetById(string id);
    }
}
