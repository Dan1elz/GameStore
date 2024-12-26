using GameStore.Domain.DTOs.InteractionContext.Review;
using GameStore.Domain.Entities.Base;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.ProductContext;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GameStore.Domain.Entities.InteractionContext
{
    public class Review : BaseEntity
    {
        [ForeignKey("Client"), Required(ErrorMessage = "Please enter the Client ID")]
        public Guid ClientId { get; private init; }
        public virtual Client Client { get; private init; }

        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; private init; }

        [Required(ErrorMessage = "Please enter the Rating")]
        public int Rating { get; private set; }
        [Required(ErrorMessage = "Please enter the Comment")]
        public string Comment { get; private set; }

        private Review() : base() { }
        public Review(CreateReviewDTO review) : base()
        {
            ClientId = review.Client.Id;
            Client = review.Client;
            ProductId = review.Product.Id;
            Product = review.Product;
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
