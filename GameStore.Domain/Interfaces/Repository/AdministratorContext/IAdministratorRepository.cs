using GameStore.Domain.Entities.AdministratorContext;
using GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.Interfaces.Repository.AdministratorContext
{
    public interface IAdministratorRepository
    {
        #nullable enable
        Task<Administrator?> Login(string Email, string Password, CancellationToken ct);
        Task<Administrator?> GetAdministratorByID(Guid id, CancellationToken ct);
    }
}
