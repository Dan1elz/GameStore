using GameStore.Aplication.DTOs.ClientContext.Client;
using GameStore.Aplication.Mappers.ClientContext.Client;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext
{
    public class GetClient(IClientRepository repository)
    {
        public readonly IClientRepository _repository = repository;

        public async Task<ReturnGetClientDTO> Execute(Token token, CancellationToken ct)
        {
            var client = await _repository.GetByIdAsync(token.Id, ct) ?? throw new Exception("Client not found");
            return MapClientToReturnGetClientDTO.Execute(client);
        }
    }
}
