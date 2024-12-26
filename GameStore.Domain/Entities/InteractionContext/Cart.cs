using GameStore.Domain.DTOs.InteractionContext.Cart;
using GameStore.Domain.Entities.Base;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.ProductContext;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Domain.Entities.InteractionContext
{
    public class Cart : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Please enter the Client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; private set; }

        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; private set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than or equal to one"), Required(ErrorMessage = "Inform the Quantity of Product")]
        public int Quantity { get; private set; }

        private Cart() : base() { }
        public Cart(CreateCartDTO cart) : base()
        {
            ClientId = cart.Client.Id;
            Client = cart.Client;
            ProductId = cart.Product.Id;
            Product = cart.Product;
            Quantity = cart.Quantity;
        }
        public void Update(UpdateCartDTO cart)
        {
            Quantity = cart.Quantity;
            base.Update();
        }
    }
}
