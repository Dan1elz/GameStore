using System.ComponentModel.DataAnnotations.Schema;
using GameStore.Domain.Entities.ProductContext;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;
using GameStore.Domain.DTOs.SaleContext.OrderItem;
using GameStore.Domain.Enum;
using GameStore.Domain.DTOs.SaleContext.Payment;

namespace GameStore.Domain.Entities.SaleContext
{
    public class Payment : BaseEntity
    {
        [ForeignKey("Order"), Required(ErrorMessage = "Please enter the Order ID")]
        public Guid OrderId { get; private init; }
        public virtual Order Order { get; set; }

        [Required(ErrorMessage = "Please enter the Payment Method")]
        public PaymentMethod PaymentMethod { get; private init; }

        [Required(ErrorMessage = "Please enter the Payment Date")]
        public DateOnly PaymentDate { get; private init; }

        [Required(ErrorMessage = "Please enter the Amount")]
        public double Amount { get; private init; }

        private Payment() : base() { }
        public Payment(CreatePaymentDTO payment) : base()
        {
            OrderId = payment.OrderId;
            PaymentMethod = payment.PaymentMethod;
            PaymentDate = payment.PaymentDate;
            Amount = payment.Amount;
        }
    }
}
