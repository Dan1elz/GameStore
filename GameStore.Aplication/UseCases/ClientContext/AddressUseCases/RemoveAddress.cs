using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.AddressUseCases
{
    public class RemoveAddress(IAddressRepository repository)
    {
        public readonly IAddressRepository _repository = repository;

        public async Task Execute(Token token, Guid Id, CancellationToken ct)
        {
            var address = await _repository.GetAsync(entity => entity.Id == Id && entity.ClientId == token.ClientId, ct) ?? throw new Exception("Address not found");
            await _repository.Remove(address, ct);
        }
    }
}
