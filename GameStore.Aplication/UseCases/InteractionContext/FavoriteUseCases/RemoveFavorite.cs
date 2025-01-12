using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.InteractionContext;

namespace GameStore.Aplication.UseCases.InteractionContext.FavoriteUseCases
{
    public class RemoveFavorite(IFavoriteRepository repository)
    {
        private readonly IFavoriteRepository _repository = repository;

        public async Task Execute(Guid productId, Token token, CancellationToken ct)
        {
            var exists = await _repository.GetAsync(f => f.ProductId == productId && f.ClientId == token.ClientId, ct) ?? throw new Exception("Not favorited");
            await _repository.Remove(exists, ct);

        }
    }
}
