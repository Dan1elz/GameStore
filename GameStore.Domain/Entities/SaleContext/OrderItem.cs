using System.ComponentModel.DataAnnotations.Schema;
using GameStore.Domain.Entities.ProductContext;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;
using GameStore.Domain.DTOs.SaleContext.OrderItem;

namespace GameStore.Domain.Entities.SaleContext
{
    public class OrderItem : BaseEntity
    {
        [ForeignKey("Order"), Required(ErrorMessage = "Please enter the Order ID")]
        public Guid OrderId { get; private init; }
        public virtual Order Order { get; set; }

        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater than or equal to zero" ),Required(ErrorMessage = "Please enter the Quantity")]
        public int Quantity { get; private init; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than or equal to zero" ),Required(ErrorMessage = "Please enter the Price")]
        public double Price { get; private init; }

        private OrderItem() : base() { }
        public OrderItem(CreateOrderItemDTO product) : base()
        {
            OrderId = product.OrderId;
            ProductId = product.ProductId;
            Quantity = product.Quantity;
            Price = product.Price;
        }

    }
}
