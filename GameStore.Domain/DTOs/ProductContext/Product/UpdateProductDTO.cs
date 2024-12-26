using GameStore.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.DTOs.ProductContext.Product
{
  public record UpdateProductDTO(string Title, string AlternativeTitle, string Description, DateOnly ReleaseDate, AgeRenge AgeRenge, string GameCover, double Price);
}
