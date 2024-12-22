using GameStore.Domain.Interfaces.Services.Base;
using GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.Interfaces.Services.ClientContext
{
    public interface IClientService : IServiceBase<Client>
    {
        Task<Client> Login(string Email, string Password);
    }
}
