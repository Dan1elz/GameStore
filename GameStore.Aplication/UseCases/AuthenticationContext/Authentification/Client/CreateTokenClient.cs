using GameStore.Aplication.UseCases.AuthenticationContext.Token;
using GameStore.Domain.DTOs.ClientContext.Token;
using GameStore.Domain.Interfaces.Repository.ClientContext;
using GameStore.Domain.Entities.ClientContext;

namespace GameStore.Aplication.UseCases.AuthenticationContext.Authentification.Client
{
    public class CreateTokenClient(ITokenRepository repository, GenerateToken generate, ValidateToken validate)
    {
        private readonly ITokenRepository _repository = repository;
        private readonly GenerateToken _generate = generate;
        private readonly ValidateToken _validate = validate;
        public async Task<string> Execute(Domain.Entities.ClientContext.Client client)
        {
            var token = await _repository.GetTokenByID(client.Id);
            if (token != null)
            {
                var validateToken = await _validate.Execute(token.Value);
                if (validateToken)
                    return token.Value;

                await _repository.Delete(token);
            }
            var newToken = await _generate.Execute(client.Id);
            token = new Domain.Entities.ClientContext.Token(new CreateTokenDTO(client, newToken));
            await _repository.Create(token);
            return newToken;
        }
    }
}
