using GameStore.Domain.Entities.AdministratorContext;

namespace GameStore.Domain.Interfaces.Repository.AdministratorContext
{
    public interface IAdministratorRepository
    {
        Task<Administrator> Login(string Email, string Password);
    }
}
