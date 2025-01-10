using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;
using GameStore.Infrastructure.Context;
using GameStore.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;
using static Dapper.SqlMapper;
using System.Linq.Expressions;
using GameStore.Domain.DTOs.ProductContext.Product;

namespace GameStore.Infrastructure.Repository.ProductContext
{
    public class ProductRepository(AppDbContext context) : BaseRepository<Product>(context), IProductRepository
    {
        public async override Task<IEnumerable<Product>> GetAllAsync(Expression<Func<Product, bool>> predicate, int offset, int limit, CancellationToken ct)
        {
            return await _context.Product
                .Include(p => p.ProductCategories)
                .Include(p => p.GameImages)
                .Include(p => p.Reviews)
                .Include(p => p.Promotions)
                .Where(predicate)
                .Skip(offset)
                .Take(limit)
                .ToListAsync(ct);
        }
    }
}
