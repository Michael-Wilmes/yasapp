using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yasapp.Domain.Entities;
using Yasapp.Infrastructure.Data;
using Yasapp.Infrastructure.Interfaces;

namespace Yasapp.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DbSet<T> _dbSet;
        private YasappDbContext _context;

        public BaseRepository(YasappDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            if (_dbSet == null)
            {
                throw new ArgumentNullException("dbSet");
            }
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T>? GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            return Task.CompletedTask;
        }

        public async Task DeleteAsync(T entity)
        {
            var exitsEntity = await _dbSet.FindAsync(entity.Id);
            if (exitsEntity != null)
            {
                _dbSet.Remove(exitsEntity);
            }
        }
    }
}
