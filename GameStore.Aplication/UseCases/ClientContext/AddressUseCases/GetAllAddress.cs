using GameStore.Domain.Interfaces.Repository.ClientContext;
using GameStore.Domain.Entities.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.AddressUseCases
{
    public class GetAllAddress(IAddressRepository repository)
    {
        public readonly IAddressRepository _repository = repository;

        public async Task<IEnumerable<Address>> Execute(Token token, CancellationToken ct)
        {
            return await _repository.GetAllAsync(entity => entity.ClientId == token.ClientId, ct);
        }
    }
}
