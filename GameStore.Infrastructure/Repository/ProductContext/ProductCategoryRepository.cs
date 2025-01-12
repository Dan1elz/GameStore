using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;
using GameStore.Infrastructure.Context;
using GameStore.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infrastructure.Repository.ProductContext
{
    public class ProductCategoryRepository(AppDbContext context) : BaseRepository<ProductCategory>(context), IProductCategoryRepository
    {
        public async Task<IEnumerable<Category>> GetCategoriesByProductIdAsync(Guid productId, CancellationToken ct)
        {
            return await _context.Set<ProductCategory>()
                .Where(pc => pc.ProductId == productId)
                .Include(pc => pc.Category)
                .Select(pc => pc.Category)
                .ToListAsync(ct);
        }
    }
}
