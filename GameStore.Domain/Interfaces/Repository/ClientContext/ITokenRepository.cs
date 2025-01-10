using GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.Interfaces.Repository.ClientContext
{
    public interface ITokenRepository
    {
        Task Create(Token token, CancellationToken ct);
        Task Delete(Token token, CancellationToken ct);
        Task<Token> GetToken(string value, CancellationToken ct);
        Task<Token> GetTokenByID(Guid id, CancellationToken ct);
    }
}
