using GameStore.Domain.DTOs.InteractionContext.Cart;
using System.ComponentModel.DataAnnotations.Schema;
using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Entities.ClientContext;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities.InteractionContext
{
    public class Cart : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Please enter the Client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; set; }

        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than or equal to one"), Required(ErrorMessage = "Inform the Quantity of Product")]
        public int Quantity { get; private set; }

        private Cart() : base() { }
        public Cart(CreateCartDTO cart) : base()
        {
            ClientId = cart.ClientId;
            ProductId = cart.ProductId;
            Quantity = cart.Quantity;
        }
        public void Update(UpdateCartDTO cart)
        {
            Quantity = cart.Quantity;
            base.Update();
        }
    }
}
