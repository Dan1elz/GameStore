using GameStore.Aplication.DTOs.ProductContext.Products;
using Comp = GameStore.Domain.Entities.ProductContext.Company;

namespace GameStore.Aplication.DTOs.ProductContext.Company
{
    public class ReturnCompanyDetailsDTO
    {
        public required Comp Company { get; set; }
        public required ReturnProductsWithRating Products { get; set; }
    }
}
