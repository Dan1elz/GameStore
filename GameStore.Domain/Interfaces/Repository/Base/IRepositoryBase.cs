using System.Linq.Expressions;
namespace GameStore.Domain.Interfaces.Repository.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        // Métodos de leitura
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);

        // Métodos de escrita
        Task AddAsync(TEntity entity); 
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task Update(TEntity entity);
        Task Remove(TEntity entity); 
        Task RemoveRange(IEnumerable<TEntity> entities);
    }
}
