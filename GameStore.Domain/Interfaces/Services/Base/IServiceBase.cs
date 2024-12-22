using System.Linq.Expressions;

namespace GameStore.Domain.Interfaces.Services.Base
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        // Métodos de leitura
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IQueryable<TEntity>> FindByCondition(Expression<Func<TEntity, bool>> expression);

        // Métodos de escrita
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IList<TEntity> entities);
        Task Update(TEntity entity);
        Task UpdateRangeAsync(IList<TEntity> entity);
        Task Remove(TEntity entity);
        Task RemoveRange(IEnumerable<TEntity> entities);
    }
}
