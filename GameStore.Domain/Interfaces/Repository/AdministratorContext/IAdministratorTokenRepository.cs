using GameStore.Domain.Entities.AdministratorContext;

namespace GameStore.Domain.Interfaces.Repository.AdministratorContext
{
    public interface IAdministratorTokenRepository
    {
        Task Create(AdministratorToken token);
        Task Delete(AdministratorToken token);
        Task<AdministratorToken> GetToken(string value);
        Task<AdministratorToken> GetTokenByID(Guid id);
    }
}
