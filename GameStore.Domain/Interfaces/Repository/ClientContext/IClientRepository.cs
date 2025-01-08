using GameStore.Domain.Interfaces.Repository.Base;
using GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.Interfaces.Repository.ClientContext
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        Task<Client> Login(string Email, string Password);
        Task<Client?> VerifyEmail(string Email);
    }
}
