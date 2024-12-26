using GameStore.Domain.DTOs.InteractionContext.Favorite;
using GameStore.Domain.Entities.Base;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.ProductContext;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Domain.Entities.InteractionContext
{
    public class Favorite : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Please enter the Client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; private init; }

        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; private init; }

        private Favorite() : base() { }
        public Favorite(CreateFavoriteDTO favorite) : base()
        {
            ClientId = favorite.Client.Id;
            Client = favorite.Client;
            ProductId = favorite.Product.Id;
            Product = favorite.Product;
        }
    }
}
