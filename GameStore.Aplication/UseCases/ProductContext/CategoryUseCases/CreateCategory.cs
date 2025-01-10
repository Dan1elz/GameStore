using GameStore.Aplication.DTOs.ProductContext.Category;
using GameStore.Domain.Interfaces.Repository.ProductContext;
using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Entities.AdministratorContext;
using GameStore.Domain.Interfaces.Repository.AdministratorContext;

namespace GameStore.Aplication.UseCases.ProductContext.CategoryUseCases
{
    public class CreateCategory(ICategoryRepository repository, IAdministratorRepository administratorRepository)
    {
        public readonly ICategoryRepository _repository = repository;
        public readonly IAdministratorRepository _administratorRepository = administratorRepository;

        public async Task Execute(RequestCreateCategoryDTO category, AdministratorToken token, CancellationToken ct)
        {
            var admin = await _administratorRepository.GetAdministratorByID(token.AdministratorId, ct);
            if (admin != null)
                throw new Exception("Administrator can't create category");

            Category newCategory = new(category.Description);
            await _repository.AddAsync(newCategory, ct);
        }
    }
}
