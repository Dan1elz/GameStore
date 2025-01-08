using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.AuthenticationContext.Authentification.Client
{
    public class DeleteTokenClient(ITokenRepository repository)
    {
        private readonly ITokenRepository _repository = repository;

        public async Task Execute(Domain.Entities.ClientContext.Client client)
        {
            var token = await _repository.GetTokenByID(client.Id) ?? throw new Exception("Token not found");
            await _repository.Delete(token);
        }
    }
}
