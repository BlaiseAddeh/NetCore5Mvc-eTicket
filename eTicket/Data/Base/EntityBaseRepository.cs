using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eTicket.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;

        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await this._context.Set<T>().AddAsync(entity);
            await this._context.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _context.Set<T>().ToListAsync();
            return result;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }


        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
        }

    }
}
