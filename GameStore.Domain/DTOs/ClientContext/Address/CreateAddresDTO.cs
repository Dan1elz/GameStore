using ClienteContext = GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.DTOs.ClientContext.Address
{
    public record CreateAddresDTO(ClienteContext.Client Client, string Street, string Number, string District, string City, string State, string ZipCode);
}