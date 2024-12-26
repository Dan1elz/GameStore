using Context = GameStore.Domain.Entities.SaleContext;
using GameStore.Domain.Enum;

namespace GameStore.Domain.DTOs.SaleContext.Payment
{
    public record CreatePaymentDTO(Context.Order Order, PaymentMethod PaymentMethod, DateOnly PaymentDate, double Amount);
}