using GameStore.Aplication.DTOs.ProductContext.Products;
using GameStore.Domain.DTOs.ProductContext.Product;
using GameStore.Domain.Interfaces.Repository.ProductContext;

namespace GameStore.Aplication.UseCases.ProductContext.ProductContext
{
    public class GetAllProductsByCompany(IProductRepository repository )
    {
        private readonly IProductRepository _repository = repository;

        public async Task<IEnumerable<ReturnProductsWithRating>> Execute(Guid companyId, int offset, int limit, CancellationToken ct)
        {
            var products = await _repository
                .GetAllAsync(entity => entity.CompanyId == companyId, offset, limit, ct);

            return products
                .Select(p => new ReturnProductsWithRating
                {
                    Product = p,
                    Category = p.ProductCategories.Select(pc => pc.Category).ToList(),
                    AverageRating = p.Reviews.Count != 0 ? p.Reviews.Average(r => r.Rating) : 0
                });
        }

    }
}
