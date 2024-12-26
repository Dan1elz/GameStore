namespace GameStore.Domain.DTOs.ProductContext.Promotion
{
    public record CreatePromotionDTO(Guid ProductId, string Description, DateTime StartDate, DateTime EndDate, double Price);
}
