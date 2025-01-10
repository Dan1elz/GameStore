using GameStore.Domain.Entities.AdministratorContext;

namespace GameStore.Domain.Interfaces.Repository.AdministratorContext
{
    public interface IAdministratorTokenRepository
    {
        Task Create(AdministratorToken token, CancellationToken ct);
        Task Delete(AdministratorToken token, CancellationToken ct);
        Task<AdministratorToken> GetToken(string value, CancellationToken ct);
        Task<AdministratorToken> GetTokenByID(Guid id, CancellationToken ct);
    }
}
