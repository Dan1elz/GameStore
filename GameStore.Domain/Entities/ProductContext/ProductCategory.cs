using GameStore.Domain.DTOs.ProductContext.ProductCategory;
using GameStore.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
            ProductId = productCategorty.Product.Id;
            Product = productCategorty.Product;
            CategoryId = productCategorty.Category.Id;
            Category = productCategorty.Category;
        }
    }
}
