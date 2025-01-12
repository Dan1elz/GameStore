using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;
using GameStore.Domain.DTOs.ProductContext.ProductCategory;

namespace GameStore.Aplication.UseCases.ProductContext.CategoryProductUseCases
{
    public class CreateProductCategory(IProductCategoryRepository repository, ICategoryRepository categoryRepository, IProductRepository productRepository)
    {
        private readonly IProductCategoryRepository _repository = repository;
        private readonly ICategoryRepository _categoryRepository = categoryRepository;
        private readonly IProductRepository _productRepository = productRepository;

        public async Task Execute(List<Guid> categoryIds, Guid productId, CancellationToken ct)
        {
            Product product = await _productRepository.GetByIdAsync(productId, ct)
               ?? throw new Exception($"Product with ID {productId} not found");

            var categories = await _categoryRepository.GetAllAsync(c => categoryIds.Contains(c.Id), 0, int.MaxValue, ct);
            var invalidCategoryIds = categoryIds.Except(categories.Select(c => c.Id)).ToList();

            if (invalidCategoryIds.Count != 0)
                throw new Exception($"Categories not found for IDs: {string.Join(", ", invalidCategoryIds)}");

            var oldProductCategories = await _repository.GetAllAsync(pc => pc.ProductId == product.Id, 0, int.MaxValue, ct);
            await _repository.RemoveRange(oldProductCategories, ct);

            List<ProductCategory> newProductCategories = categories.Select(category =>
                new ProductCategory(new CreateProductCategoryDTO(product, category))
            ).ToList();

            await _repository.AddRangeAsync(newProductCategories, ct);
        }
    }
}
