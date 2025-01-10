using GameStore.Domain.Entities.ProductContext;
using Cat = GameStore.Domain.Entities.ProductContext.Category;

namespace GameStore.Aplication.DTOs.ProductContext.Products
{
    public class ReturnProductsWithRating
    {
        public required Product Product { get; set; }
        public double AverageRating { get; set; }
        public required List<Cat> Category { get; set; }
     }
}
