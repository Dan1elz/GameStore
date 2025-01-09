using System.Linq.Expressions;
namespace GameStore.Domain.Interfaces.Repository.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        #nullable enable
        // Métodos de leitura
        Task<TEntity?> GetByIdAsync(Guid id, CancellationToken ct);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken ct);
        Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken ct);

        // Métodos de escrita
        Task AddAsync(TEntity entity, CancellationToken ct); 
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken ct);
        Task Update(TEntity entity, CancellationToken ct);
        Task Remove(TEntity entity, CancellationToken ct); 
        Task RemoveRange(IEnumerable<TEntity> entities, CancellationToken ct);
    }
}
