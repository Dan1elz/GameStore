using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;

namespace GameStore.Aplication.UseCases.ProductContext.CategoryUseCases
{
    public class GetAllCategory(ICategoryRepository repository)
    {
        public readonly ICategoryRepository _repository = repository;

        public async Task<IEnumerable<Category>> Execute(CancellationToken ct)
        {
            return await _repository.GetAllAsync(entity => true, ct);
        }
    }
}
