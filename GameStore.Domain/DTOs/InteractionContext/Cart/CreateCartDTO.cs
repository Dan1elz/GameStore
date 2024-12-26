namespace GameStore.Domain.DTOs.InteractionContext.Cart
{
    public record CreateCartDTO(Guid ClientId, Guid ProductId, int Quantity);
}
