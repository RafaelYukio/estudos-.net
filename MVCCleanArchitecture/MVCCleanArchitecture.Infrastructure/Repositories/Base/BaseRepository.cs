using Microsoft.EntityFrameworkCore;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.Base;
using MVCCleanArchitecture.Infrastructure.Data;

namespace MVCCleanArchitecture.Infrastructure.Repositories.Base
{
    public abstract class BaseRepository<T>(ApplicationDbContext context) : IBaseRepository<T> where T : class
    {
        public readonly DbSet<T> _DbSet = context.Set<T>();
        public readonly ApplicationDbContext _context = context;

        public virtual async Task<T> InsertAsync(T entity)
        {
            _DbSet.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            _DbSet.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public virtual async Task<List<T>> GetAllAsync() => await _DbSet.AsNoTracking().ToListAsync();
    }
}