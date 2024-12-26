using GameStore.Domain.DTOs.ProductContext.ProductCategory;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities.ProductContext
{
    public class ProductCategory : BaseEntity
    {
        [ForeignKey("Product"), Required(ErrorMessage = "Please enter the product ID")]
        public Guid ProductId { get; private init; }
        public virtual Product Product { get; set; }

        [ForeignKey("Category"), Required(ErrorMessage = "Please enter the category ID")]
        public Guid CategoryId { get; private init; }
        public virtual Category Category { get; set; }

        private ProductCategory() : base() { }
        public ProductCategory(CreateProductCategoryDTO productCategorty) : base()
        {
            ProductId = productCategorty.ProductId;
            CategoryId = productCategorty.CategoryId;
        }
    }
}
