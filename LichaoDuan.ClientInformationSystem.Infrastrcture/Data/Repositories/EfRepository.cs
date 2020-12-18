using LichaoDuan.ClientInformationSystem.Core.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Infrastrcture.Data.Repositories
{
    public class EfRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly ClientInformationSystemDbContext _clientInformationSystemDbContext;
        public EfRepository(ClientInformationSystemDbContext dbContext)
        {
            _clientInformationSystemDbContext = dbContext;
        }
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _clientInformationSystemDbContext.Set<T>().FindAsync(id);
        }
        public async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _clientInformationSystemDbContext.Set<T>().ToListAsync();
        }
        public async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter)
        {
            return await _clientInformationSystemDbContext.Set<T>().Where(filter).ToListAsync();
        }
        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null)
            {
                return await _clientInformationSystemDbContext.Set<T>().Where(filter).CountAsync();
            }
            return await _clientInformationSystemDbContext.Set<T>().CountAsync();
        }
        public async Task<bool> GetExistsAsync(Expression<Func<T, bool>> filter = null)
        {
            if (filter != null && await _clientInformationSystemDbContext.Set<T>().Where(filter).AnyAsync())
                return true;
            return false;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _clientInformationSystemDbContext.Set<T>().AddAsync(entity);
            await _clientInformationSystemDbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<T> UpdateAsync(T entity)
        {
            _clientInformationSystemDbContext.Entry(entity).State = EntityState.Modified;
            await _clientInformationSystemDbContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _clientInformationSystemDbContext.Set<T>().Remove(entity);
            await _clientInformationSystemDbContext.SaveChangesAsync();
        }
    }
}
