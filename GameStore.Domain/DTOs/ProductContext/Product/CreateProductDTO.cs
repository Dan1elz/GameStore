using GameStore.Domain.Enum;

namespace GameStore.Domain.DTOs.ProductContext.Product
{
    public record CreateProductDTO(Guid CompanyId, string Title, string? AlternativeTitle, string Description, DateOnly ReleaseDate, AgeRenge AgeRenge, string GameCover, double Price);
}
