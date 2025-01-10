using GameStore.Domain.Interfaces.Repository.InteractionContext;
using GameStore.Domain.Entities.InteractionContext;

namespace GameStore.Aplication.UseCases.InteractionContext.ReviewUseCases
{
    internal class GetAllReviewByProduct(IReviewRepository repository)
    {
        private readonly IReviewRepository _repository = repository;

        public async Task<IEnumerable<Review>> Execute(Guid productId, int offset, int limit, CancellationToken ct)
        {
            return await _repository.GetAllAsync(entity => entity.ProductId == productId, offset, limit, ct);
        }
    }
}
