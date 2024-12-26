using GameStore.Domain.DTOs.SaleContext.Payment;
using GameStore.Domain.Entities.Base;
using GameStore.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Domain.Entities.SaleContext
{
    public class Payment : BaseEntity
    {
        [ForeignKey("Order"), Required(ErrorMessage = "Please enter the Order ID")]
        public Guid OrderId { get; private init; }
        public virtual Order Order { get; private init; }

        [Required(ErrorMessage = "Please enter the Payment Method")]
        public PaymentMethod PaymentMethod { get; private init; }

        [Required(ErrorMessage = "Please enter the Payment Date")]
        public DateOnly PaymentDate { get; private init; }

        [Required(ErrorMessage = "Please enter the Amount")]
        public double Amount { get; private init; }

        private Payment() : base() { }
        public Payment(CreatePaymentDTO payment) : base()
        {
            OrderId = payment.Order.Id;
            Order = payment.Order;
            PaymentMethod = payment.PaymentMethod;
            PaymentDate = payment.PaymentDate;
            Amount = payment.Amount;
        }
    }
}
