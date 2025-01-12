using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;

namespace GameStore.Aplication.UseCases.ProductContext.CategoryProductUseCases
{
    public class RemoveAllProductCategory(IProductCategoryRepository repository, IProductRepository productRepository)
    {
        private readonly IProductCategoryRepository _repository = repository;
        private readonly IProductRepository _productRepository = productRepository;

        public async Task Execute(Guid productId, CancellationToken ct)
        {
            Product product = await _productRepository.GetByIdAsync(productId, ct)
               ?? throw new Exception($"Product with ID {productId} not found");

            var productCategories = await _repository.GetAllAsync(pc => pc.ProductId == product.Id, 0, int.MaxValue, ct);
            await _repository.RemoveRange(productCategories, ct);
        }
    }
}
