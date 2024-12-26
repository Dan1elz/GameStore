using GameStore.Domain.DTOs.ProductContext.GameImage;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities.ProductContext
{
    public class GameImage : BaseEntity
    {
        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; set; }

        [Required(ErrorMessage = "Inform the Image URL")]
        public string ImageURL { get; private set; } = string.Empty;

        [MaxLength(255, ErrorMessage = "Image Description must have at most 255 characters"), Required(ErrorMessage = "Inform the Image Description")]
        public string Description { get; private set; }
        
        private GameImage() : base() { }
        public GameImage(CreateGameImageDTO gameImage) : base()
        {
            ProductId = gameImage.ProductId;
            ImageURL = gameImage.ImageURL;
            Description = gameImage.Description;
        }
    }
}
