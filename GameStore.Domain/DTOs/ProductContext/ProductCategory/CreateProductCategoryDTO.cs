using GameStore.Domain.Entities.ProductContext;
using Context = GameStore.Domain.Entities.ProductContext;

namespace GameStore.Domain.DTOs.ProductContext.ProductCategory
{
    public record CreateProductCategoryDTO(Context.Product Product, Category Category);
}
