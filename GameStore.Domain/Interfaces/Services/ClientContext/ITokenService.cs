using GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.Interfaces.Services.ClientContext
{
    internal interface ITokenService
    {
        Task Create(Token token);
        Task Dekete(Token token);
        Task<Token> GetToken(string value);
        Task<Token> GetTokenByID(Guid id);
    }
}
