using Context = GameStore.Domain.Entities.ProductContext;

namespace GameStore.Domain.DTOs.ProductContext.Promotion
{
    public record CreatePromotionDTO(Context.Product Product, string Description, DateTime StartDate, DateTime EndDate, double Price);
}
