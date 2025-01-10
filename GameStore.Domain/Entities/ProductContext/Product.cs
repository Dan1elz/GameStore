using GameStore.Domain.DTOs.ProductContext.Product;
using GameStore.Domain.Entities.Base;
using GameStore.Domain.Entities.InteractionContext;
using GameStore.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Domain.Entities.ProductContext
{
    public class Product : BaseEntity
    {
        #nullable enable
        [ForeignKey("Company"), Required(ErrorMessage = "Please enter the company ID")]
        public Guid CompanyId { get; private init; }
        public virtual Company Company { get; private init; }

        [MaxLength(255, ErrorMessage = "Title must have at most 255 characters"), Required(ErrorMessage = "Inform the Title of Product")]
        public string Title { get; private set; } = string.Empty;

        [MaxLength(255, ErrorMessage = "Alternative Title must have at most 255 characters")]
        public string? AlternativeTitle { get; private set; }

        [MaxLength(255, ErrorMessage = "Description must have at most 255 characters"), Required(ErrorMessage = "Inform the Description of Product")]
        public string Description { get; private set; } = string.Empty;

        [Required(ErrorMessage = "Informe the Release Date of Product")]
        public DateOnly ReleaseDate { get; private set; }

        [Required(ErrorMessage = "Inform the Age Renge of Product")]
        public AgeRenge AgeRenge { get; private set; } = AgeRenge.EVERYONE;

        [Required(ErrorMessage = "Inform the Game Cover of Product")]
        public string GameCover { get; private set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "Price must be greater than or equal to zero"), Required(ErrorMessage = "Inform the Game Price of Product")]
        public double Price { get; private set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<GameImage> GameImages { get; set; }
        public virtual ICollection<Promotion> Promotions { get; set; }

#pragma warning disable CS8618
        private Product() : base() {}
        public Product(CreateProductDTO product) : base()
        {
            CompanyId = product.Company.Id;
            Company = product.Company;
            Title = product.Title;
            AlternativeTitle = product.AlternativeTitle;
            Description = product.Description;
            ReleaseDate = product.ReleaseDate;
            AgeRenge = product.AgeRenge;
            GameCover = product.GameCover;
            Price = product.Price;
        }
        public void Update(UpdateProductDTO product)
        {
            Title = product.Title;
            AlternativeTitle = product.AlternativeTitle;
            Description = product.Description;
            ReleaseDate = product.ReleaseDate;
            AgeRenge = product.AgeRenge;
            GameCover = product.GameCover;
            Price = product.Price;
            base.Update();
        }
    }
}
