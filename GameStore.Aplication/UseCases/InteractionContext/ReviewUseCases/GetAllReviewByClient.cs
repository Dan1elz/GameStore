using GameStore.Domain.Entities.InteractionContext;
using GameStore.Domain.Interfaces.Repository.InteractionContext;

namespace GameStore.Aplication.UseCases.InteractionContext.ReviewUseCases
{
    public class GetAllReviewByClient(IReviewRepository repository)
    {
        private readonly IReviewRepository _repository = repository;

        public async Task<IEnumerable<Review>> Execute(Guid clientId, int offset, int limit, CancellationToken ct)
        {
            return await _repository.GetAllAsync(entity => entity.ClientId == clientId, offset, limit, ct);
        }
    }
}
