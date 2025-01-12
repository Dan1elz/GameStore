using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;

namespace GameStore.Aplication.UseCases.ProductContext.CategoryProductUseCases
{
    public class GetAllProductCategory(IProductCategoryRepository repository, IProductRepository productRepository)
    {
        private readonly IProductCategoryRepository _repository = repository;
        private readonly IProductRepository _productRepository = productRepository;

        public async Task<IEnumerable<Category>> Execute(Guid productId, CancellationToken ct)
        {
            Product product = await _productRepository.GetByIdAsync(productId, ct)
               ?? throw new Exception($"Product with ID {productId} not found");

            return await _repository.GetCategoriesByProductIdAsync(product.Id, ct);
        }
    }
}
