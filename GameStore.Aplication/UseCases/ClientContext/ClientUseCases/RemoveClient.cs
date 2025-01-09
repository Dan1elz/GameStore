using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.ClientUseCases
{
    public class RemoveClient(IClientRepository repository)
    {
        public readonly IClientRepository _repository = repository;

        public async Task Execute(Token token, CancellationToken ct)
        {
            var client = await _repository.GetByIdAsync(token.Id, ct) ?? throw new Exception("Client not found");

            if (client.Inventoryes.Any())
                throw new Exception("Client has inventoryes");

            await _repository.Remove(client, ct);
        }
    }
}
