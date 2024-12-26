using GameStore.Domain.Enum;

namespace GameStore.Domain.DTOs.SaleContext.Payment
{
    public record CreatePaymentDTO(Guid OrderId, PaymentMethod PaymentMethod, DateOnly PaymentDate, double Amount);
}