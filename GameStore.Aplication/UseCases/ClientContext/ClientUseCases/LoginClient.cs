using GameStore.Aplication.UseCases.AuthenticationContext.Authentification.Client;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.ClientUseCases
{
    public class LoginClient(IClientRepository repository, CreateTokenClient service)
    {
        public readonly IClientRepository _repository = repository;
        public readonly CreateTokenClient _service = service;

        public async Task<string?> Execute(string Email, string Password, CancellationToken ct)
        {
            var login = await _repository.Login(Email, Password, ct) ?? throw new Exception("Email or password incorrect");
            var token = await _service.Execute(login) ?? throw new Exception("Error to create token");
            return token;
        }
    }
}
