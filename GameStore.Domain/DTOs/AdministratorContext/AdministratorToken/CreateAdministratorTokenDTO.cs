using GameStore.Domain.Entities.AdministratorContext;

namespace GameStore.Domain.DTOs.AdministratorContext.Token
{
    public record CreateAdministratorTokenDTO(Administrator Administrator, string Value);
}
