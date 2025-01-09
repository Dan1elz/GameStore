using GameStore.Aplication.DTOs.ClientContext.Address;
using GameStore.Domain.DTOs.ClientContext.Address;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.AddressUseCases
{
    public class UpdateAddress(IAddressRepository repository)
    {
        private readonly IAddressRepository _repository = repository;

        public async Task Execute(RequestUpdateAddresDTO _address, Token token, Guid Id, CancellationToken ct)
        {
            var address = await _repository.GetAsync(entity => entity.Id == Id && entity.ClientId == token.ClientId, ct) ?? throw new Exception("Address not found");
            address.Update(new UpdateAddressDTO(_address.Street, _address.Number, _address.District, _address.City, _address.State, _address.ZipCode));
            await _repository.Update(address, ct);
        }
    }
}
