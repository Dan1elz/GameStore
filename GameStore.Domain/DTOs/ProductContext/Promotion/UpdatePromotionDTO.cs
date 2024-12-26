namespace GameStore.Domain.DTOs.ProductContext.Promotion
{
    public record UpdatePromotionDTO(string Description, DateTime StartDate, DateTime EndDate, double Price);
}
