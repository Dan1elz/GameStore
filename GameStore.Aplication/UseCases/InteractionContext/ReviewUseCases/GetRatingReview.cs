using GameStore.Domain.Interfaces.Repository.InteractionContext;

namespace GameStore.Aplication.UseCases.InteractionContext.ReviewUseCases
{
    public class GetRatingReview(IReviewRepository repository)
    {
        private readonly IReviewRepository _repository = repository;

        public async Task<double> Execute(Guid productId, CancellationToken ct)
        {
            var reviews = await _repository.GetAllAsync(entity => entity.ProductId == productId, 0, int.MaxValue , ct);
            return reviews.Average(entity => entity.Rating);
        }
    }
}
