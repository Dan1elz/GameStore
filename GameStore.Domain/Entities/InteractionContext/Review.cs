using GameStore.Domain.DTOs.InteractionContext.Review;
using System.ComponentModel.DataAnnotations.Schema;
using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Entities.ClientContext;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;


namespace GameStore.Domain.Entities.InteractionContext
{
    public class Review : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Please enter the Client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; set; }

        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; set; }

        [Required(ErrorMessage = "Please enter the Rating")]
        public int Rating { get; private set;}
        [Required(ErrorMessage = "Please enter the Comment")]
        public string Comment { get; private set; }

        private Review() : base() { }
        public Review(CreateReviewDTO review) : base()
        {
            ClientId = review.ClientId;
            ProductId = review.ProductId;
            Rating = review.Rating;
            Comment = review.Comment;
        }
        public void Update(UpdateReviewDTO review)
        {
            Rating = review.Rating;
            Comment = review.Comment;
        }
    }
}
