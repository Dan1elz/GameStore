using GameStore.Aplication.UseCases.AuthenticationContext.Token;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.AuthenticationContext.Authentification.Client
{
    public class AuthenticationTokenClient(ITokenRepository repository, GenerateToken generate, ValidateToken validate)
    {
        private readonly ITokenRepository _repository = repository;
        private readonly ValidateToken _validate = validate;
        public async Task<GameStore.Domain.Entities.ClientContext.Token?> Execute(string _token)
        {
            var token = await _repository.GetToken(_token) ?? throw new Exception("Token not found");
            var validateToken = await _validate.Execute(token.Value);
            return !validateToken ? throw new Exception("Token expired, please log in again ") : token;
        }
    }
}
