using GameStore.Aplication.DTOs.ClientContext.Address;
using GameStore.Domain.DTOs.ClientContext.Address;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.AddressUseCases
{
    public class CreateAddress(IAddressRepository repository)
    {
        public readonly IAddressRepository _repository = repository;

        public async Task Execute(RequestCreateAddresDTO address, Token token, CancellationToken ct)
        {
            Address newAddress = new(new CreateAddresDTO(token.Client, address.Street, address.Number, address.District, address.City, address.State, address.ZipCode));
            await _repository.AddAsync(newAddress, ct);
        }
    }
}
