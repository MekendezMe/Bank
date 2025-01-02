using BankCoreAPI.Core.Interfaces;
using BankCoreAPI.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BankCoreAPI.Core.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            var result = await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var result = _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> DeleteAsync(long id)
        {
            var entity = await _dbSet.FindAsync(id);

            if (entity == null) return false;

            _dbSet.Remove(entity);

            try
            {
                return await _context.SaveChangesAsync() > 0;
            }
            catch (DbUpdateException dbUpdateException)
            {
                Debug.WriteLine($"Error deleting entity with id: {id}: {dbUpdateException.Message}");
                throw;
            }
        }
    }
}
