namespace GameStore.Domain.DTOs.SaleContext.OrderItem
{
    public record CreateOrderItemDTO(Guid OrderId, Guid ProductId, int Quantity, double Price);
}