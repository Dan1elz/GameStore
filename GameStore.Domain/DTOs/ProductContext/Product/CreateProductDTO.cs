using Context = GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Enum;

namespace GameStore.Domain.DTOs.ProductContext.Product
{
    public record CreateProductDTO(Context.Company Company, string Title, string? AlternativeTitle, string Description, DateOnly ReleaseDate, AgeRenge AgeRenge, string GameCover, double Price);
}
