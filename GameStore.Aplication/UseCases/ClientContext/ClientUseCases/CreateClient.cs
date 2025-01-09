using GameStore.Aplication.DTOs.ClientContext.Client;
using GameStore.Domain.DTOs.ClientContext.Client;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.ClientUseCases
{
    public class CreateClient(IClientRepository repository)
    {
        public readonly IClientRepository _repository = repository;

        public async Task Execute(RequestCreateClientDTO client, CancellationToken ct)
        {
            var verifyEmail = await _repository.VerifyEmail(client.Email, ct);
            if (verifyEmail != null)
                throw new Exception("Email already registered");

            Client newClient = new(new CreateClientDTO(client.Name, client.LastName, client.Email, client.Password, client.BirthDate, client.CPF));
            await _repository.AddAsync(newClient, ct);
        }
    }
}
