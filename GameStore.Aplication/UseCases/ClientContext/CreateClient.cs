using GameStore.Domain.Interfaces.Repository.ClientContext;
using GameStore.Domain.DTOs.ClientContext.Client;
using GameStore.Domain.Entities.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext
{
    public class CreateClient(IClientRepository repository)
    {
        public readonly IClientRepository _repository = repository;

        public async Task Execute(CreateClientDTO client)
        {
            var verifyEmail = await _repository.VerifyEmail(client.Email);
            if(verifyEmail != null)    
                throw new Exception("Email already registered");

            Client newClient = new(client);
            await _repository.AddAsync(newClient);
        }

    }
}
