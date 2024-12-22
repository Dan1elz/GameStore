using ClienteContext = GameStore.Domain.Entities.ClientContext;

namespace GameStore.Domain.DTOs.ClientContext.Contact
{
    public record CreateContactDTO(ClienteContext.Client Client, string Description, string PhoneNumber, string Email);
}
