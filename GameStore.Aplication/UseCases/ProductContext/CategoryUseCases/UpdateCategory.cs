using GameStore.Aplication.DTOs.ProductContext.Category;
using GameStore.Domain.Entities.AdministratorContext;
using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Interfaces.Repository.AdministratorContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;

namespace GameStore.Aplication.UseCases.ProductContext.CategoryUseCases
{
    public class UpdateCategory(ICategoryRepository repository, IAdministratorRepository administratorRepository)
    {
        public readonly ICategoryRepository _repository = repository;
        public readonly IAdministratorRepository _administratorRepository = administratorRepository;


        public async Task Execute(RequestUpdateCategoryDTO _category, Guid Id, AdministratorToken token, CancellationToken ct)
        {
            var admin = await _administratorRepository.GetAdministratorByID(token.AdministratorId, ct);
            if (admin != null)
                throw new Exception("Administrator can't create category");

            var category = await _repository.GetByIdAsync(Id, ct) ?? throw new Exception("Category not found");
            category.Update(_category.Description);
            await _repository.Update(category, ct);
        }
    }
}
