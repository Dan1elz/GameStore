using GameStore.Aplication.DTOs.ClientContext.Client;
using GameStore.Aplication.UseCases.AuthenticationContext.Authentification.Client;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.DTOs.ClientContext.Client;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.ClientUseCases
{
    public class UpdateClient(IClientRepository repository, CreateTokenClient service)
    {
        public readonly IClientRepository _repository = repository;
        public readonly CreateTokenClient _service = service;

        public async Task Execute(RequestUpdateClientDTO _client, Token token, CancellationToken ct)
        {
            var clientToUpdate = await _repository.GetByIdAsync(token.ClientId, ct) ?? throw new Exception("Client not found");
            if (clientToUpdate.Email != _client.Email || clientToUpdate.Password != _client.Password)
                throw new Exception("Email or password incorrect");

            clientToUpdate.Update(new UpdateClientDTO(_client.Name, _client.LastName));
            await _repository.Update(clientToUpdate, ct);
        }

    }
}
