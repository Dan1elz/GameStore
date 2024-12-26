﻿using System.ComponentModel.DataAnnotations.Schema;
using GameStore.Domain.DTOs.SaleContext.Order;
using GameStore.Domain.Entities.ClientContext;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;
using GameStore.Domain.Enum;

namespace GameStore.Domain.Entities.SaleContext
{
    public class Order : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Please enter the Client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; set; }

        [Required(ErrorMessage = "Inform the Order Status of Order")]
        public OrderStatus OrderStatus { get; private set; } = OrderStatus.PENDING;

        [Required(ErrorMessage = "Inform the Payment Status of Order")]
        public PaymentStatus PaymentStatus { get; private set; } = PaymentStatus.PENDING;

        [Range(0, double.MaxValue, ErrorMessage = "Total Price must be greater than or equal to zero" ),Required(ErrorMessage = "Please enter the Total Price")]
        public double TotalPrice { get; private init; }

        private Order() : base() { }
        public Order(CreateOrderDTO product) : base()
        {
            ClientId = product.ClientId;
            TotalPrice = product.TotalPrice;
        }

        public void Update(UpdateOrderDTO product)
        {
            OrderStatus = product.OrderStatus;
            PaymentStatus = product.PaymentStatus;
        }
    }
}
