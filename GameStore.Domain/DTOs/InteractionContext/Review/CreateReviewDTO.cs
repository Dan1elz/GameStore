using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.ProductContext;

namespace GameStore.Domain.DTOs.InteractionContext.Review
{
    public record CreateReviewDTO(Client Client, Product Product, int Rating, string Comment);
}
