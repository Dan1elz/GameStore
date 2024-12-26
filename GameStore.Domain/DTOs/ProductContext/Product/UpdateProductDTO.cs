using GameStore.Domain.Enum;

namespace GameStore.Domain.DTOs.ProductContext.Product
{
  public record UpdateProductDTO(string Title, string AlternativeTitle, string Description, DateOnly ReleaseDate, AgeRenge AgeRenge, string GameCover, double Price);
}
