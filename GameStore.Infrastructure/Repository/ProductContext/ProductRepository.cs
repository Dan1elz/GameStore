using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;
using GameStore.Infrastructure.Context;
using GameStore.Infrastructure.Repository.Base;

namespace GameStore.Infrastructure.Repository.ProductContext
{
    public class ProductRepository(AppDbContext context) : BaseRepository<Product>(context), IProductRepository
    {
    }
}
