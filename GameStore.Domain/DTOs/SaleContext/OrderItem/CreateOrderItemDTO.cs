using GameStore.Domain.Entities.ProductContext;
using Context = GameStore.Domain.Entities.SaleContext;

namespace GameStore.Domain.DTOs.SaleContext.OrderItem
{
    public record CreateOrderItemDTO(Context.Order Order, Product Product, int Quantity, double Price);
}