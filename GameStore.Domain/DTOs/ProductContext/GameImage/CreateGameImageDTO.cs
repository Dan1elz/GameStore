namespace GameStore.Domain.DTOs.ProductContext.GameImage
{
    public record CreateGameImageDTO(Guid ProductId, string ImageURL, string Description);
}
