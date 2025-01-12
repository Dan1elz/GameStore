using GameStore.Domain.Interfaces.Repository.Base;
using GameStore.Domain.Entities.ProductContext;

namespace GameStore.Domain.Interfaces.Repository.ProductContext
{
    public interface IProductCategoryRepository : IRepositoryBase<ProductCategory>
    {
        Task<IEnumerable<Category>> GetCategoriesByProductIdAsync(Guid productId, CancellationToken ct);

    }
}
