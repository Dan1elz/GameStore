using GameStore.Domain.Interfaces.Repository.Base;
using GameStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GameStore.Infrastructure.Repository.Base
{
    public abstract class BaseRepository<TEntity>(AppDbContext context) : IRepositoryBase<TEntity> where TEntity : class
    {
        #nullable enable
        protected readonly AppDbContext _context = context;
        protected readonly DbSet<TEntity> DbSet = context.Set<TEntity>();

        public virtual async Task AddAsync(TEntity entity, CancellationToken ct)
        {
            await _context.Set<TEntity>().AddAsync(entity, ct);
            await _context.SaveChangesAsync(ct);
        }

        public virtual async Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken ct)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities, ct);
            await _context.SaveChangesAsync(ct);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, int offset, int limit, CancellationToken ct)
        {
            return await _context.Set<TEntity>().Where(predicate)
                .Skip(offset)
                .Take(limit)
                .ToListAsync(ct);
        }
        
        public virtual async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken ct)
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync(predicate, ct);
        }

        public virtual async Task<TEntity?> GetByIdAsync(Guid Id, CancellationToken ct)
        {
            return await _context.Set<TEntity>().FindAsync([Id], cancellationToken: ct);
        }
        public virtual async Task Remove(TEntity entity, CancellationToken ct)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync(ct);
        }
        public virtual async Task RemoveRange(IEnumerable<TEntity> entities, CancellationToken ct)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            await _context.SaveChangesAsync(ct);
        }
        public virtual async Task Update(TEntity entity, CancellationToken ct)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync(ct);
        }
    }
}
