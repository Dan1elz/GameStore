using GameStore.Domain.Interfaces.Repository.Base;
using GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.Interfaces.Repository.ClientContext
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        #nullable enable
        Task<Client> Login(string Email, string Password, CancellationToken ct);
        Task<Client?> VerifyEmail(string Email, CancellationToken ct);
    }
}
