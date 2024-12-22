using ClienteContext = GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.DTOs.ClientContext.Token
{
    public record CreateTokenDTO(ClienteContext.Client Client, string Value);
}
