namespace GameStore.Domain.DTOs.InteractionContext.Review
{
    public record CreateReviewDTO(Guid ClientId, Guid ProductId, int Rating, string Comment);
}
