﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Persistence.Contexts;

namespace SchoolAutomationProject.Persistence.Repositories.CommonRepositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseClass
    {
        private readonly SchoolAutomationProjectDbContext _context;

        public WriteRepository(SchoolAutomationProjectDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task AddRangeAsync(List<T> entities)
        {
            foreach (var entity in entities)
            {
                await AddAsync(entity);
                await SaveChangesAsync();
            }
        }

        public void Remove(T entity)
        {
            //EntityEntry<T> entityEntry = Table.Remove(entity);
            //return entityEntry.State == EntityState.Deleted;
            entity.IsActive = false;
        }

        public async Task RemoveByIdAsync(Guid id)
        {
            T data = await Table.FindAsync(id);
            data.IsActive = false;
        }

        public bool Update<TWriteViewModel>(T entity, TWriteViewModel modelVM)
        {
            _context.Entry(entity).CurrentValues.SetValues(modelVM);
            EntityEntry<T> entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task SaveChangesAsync()
        => await _context.SaveChangesAsync();

    }
}
