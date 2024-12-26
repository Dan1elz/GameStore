namespace GameStore.Domain.DTOs.SaleContext.Order
{
    public record CreateOrderDTO(Guid ClientId, double TotalPrice);
}