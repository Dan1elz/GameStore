using GameStore.Domain.DTOs.InteractionContext.Favorite;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.InteractionContext;
using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Interfaces.Repository.InteractionContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;

namespace GameStore.Aplication.UseCases.InteractionContext.FavoriteUseCases
{
    public class AddFavorite(IFavoriteRepository repository, IProductRepository productRepository)
    {
        private readonly IFavoriteRepository _repository = repository;
        private readonly IProductRepository _productRepository = productRepository;

        public async Task Execute(Guid productId, Token token, CancellationToken ct)
        {
            Product product = await _productRepository.GetByIdAsync(productId, ct)
              ?? throw new Exception($"Product with ID {productId} not found");

            var exists = await _repository.GetAsync(f => f.ProductId == product.Id && f.ClientId == token.ClientId, ct);
            if (exists != null) throw new Exception("Already favorited");

            Favorite favorite = new(new CreateFavoriteDTO(token.Client, product));
            await _repository.AddAsync(favorite, ct);
        }
    }
}
