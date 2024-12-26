using Context = GameStore.Domain.Entities.ProductContext;

namespace GameStore.Domain.DTOs.ProductContext.GameImage
{
    public record CreateGameImageDTO(Context.Product Product, string ImageURL, string Description);
}
