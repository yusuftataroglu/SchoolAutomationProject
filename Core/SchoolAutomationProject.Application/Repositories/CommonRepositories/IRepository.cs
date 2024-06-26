﻿using Microsoft.EntityFrameworkCore;
using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.Application.Repositories.CommonRepositories
{
    public interface IRepository<T> where T : BaseClass
    {
        public DbSet<T> Table { get; }
    }
}
