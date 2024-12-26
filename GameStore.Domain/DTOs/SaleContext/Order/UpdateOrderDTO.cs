using GameStore.Domain.Enum;

namespace GameStore.Domain.DTOs.SaleContext.Order
{
    public record UpdateOrderDTO(OrderStatus OrderStatus, PaymentStatus PaymentStatus);
}