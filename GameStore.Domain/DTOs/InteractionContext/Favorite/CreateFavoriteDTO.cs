namespace GameStore.Domain.DTOs.InteractionContext.Favorite
{
    public record CreateFavoriteDTO(Guid ClientId, Guid ProductId)
    {
    }
}
