using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.ProductContext;

namespace GameStore.Domain.DTOs.InteractionContext.Cart
{
    public record CreateCartDTO(Client Client, Product Product, int Quantity);
}
