using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.ProductContext;

namespace GameStore.Domain.DTOs.InteractionContext.Favorite
{
    public record CreateFavoriteDTO(Client Client, Product Product)
    {
    }
}
