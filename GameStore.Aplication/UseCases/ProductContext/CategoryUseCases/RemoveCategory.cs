using GameStore.Domain.Entities.AdministratorContext;
using GameStore.Domain.Interfaces.Repository.AdministratorContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;

namespace GameStore.Aplication.UseCases.ProductContext.CategoryUseCases
{
    public class RemoveCategory(ICategoryRepository repository, IProductCategoryRepository productCategoryRepository, IAdministratorRepository administratorRepository)
    {
        public readonly ICategoryRepository _repository = repository;
        public readonly IProductCategoryRepository _productCategoryRepository = productCategoryRepository;
        public readonly IAdministratorRepository _administratorRepository = administratorRepository;

        public async Task Execute(Guid Id, AdministratorToken token, CancellationToken ct)
        {
            var admin = await _administratorRepository.GetAdministratorByID(token.AdministratorId, ct);
            if (admin != null)
                throw new Exception("Administrator can't create category");

            var category = await _repository.GetByIdAsync(Id, ct) ?? throw new Exception("Category not found");

            var productCategory = await _productCategoryRepository.GetAllAsync(entity => entity.CategoryId == category.Id, ct);
            if (productCategory.Any())
                throw new Exception("There are products with this category");

            await _repository.Remove(category, ct);
        }
    }
}
