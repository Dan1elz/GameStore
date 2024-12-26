using GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.DTOs.SaleContext.Order
{
    public record CreateOrderDTO(Client Client, double TotalPrice);
}