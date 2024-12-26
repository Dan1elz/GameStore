using GameStore.Domain.DTOs.ProductContext.Promotion;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities.ProductContext
{
    public class Promotion : BaseEntity
    {
        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; set; }

        [Required(ErrorMessage = "Inform the Promotion Description")]
        public string Description { get; private set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "Promotion Price must be greater than or equal to zero"), Required(ErrorMessage = "Inform the Promotion Price")]
        public double Price { get; private set; }

        [Required(ErrorMessage = "Inform the Promotion Start Date")]
        public DateTime StartDate { get; private set; }

        [Required(ErrorMessage = "Inform the Promotion End Date")]
        public DateTime EndDate { get; private set; }

        private Promotion() : base() { }
        public Promotion(CreatePromotionDTO promotion) : base()
        {
            ProductId = promotion.ProductId;
            Description = promotion.Description;
            Price = promotion.Price;
            StartDate = promotion.StartDate;
            EndDate = promotion.EndDate;
        }

        public void Update(UpdatePromotionDTO promotion)
        {
            Description = promotion.Description;
            Price = promotion.Price;
            StartDate = promotion.StartDate;
            EndDate = promotion.EndDate;
            base.Update();
        }
    }
}
