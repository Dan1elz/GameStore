using GameStore.Domain.DTOs.InteractionContext.Favorite;
using System.ComponentModel.DataAnnotations.Schema;
using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Entities.ClientContext;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities.InteractionContext
{
    public class Favorite : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Please enter the Client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; set; }

        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; set; }

        private Favorite() : base() { }
        public Favorite(CreateFavoriteDTO favorite) : base()
        {
            ClientId = favorite.ClientId;
            ProductId = favorite.ProductId;
        }
    }
}
