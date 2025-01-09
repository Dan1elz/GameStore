using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.InteractionContext;

namespace GameStore.Aplication.DTOs.ClientContext.Client
{
    public record ReturnGetClientDTO(Guid Id, string Name, string LastName, string Email, DateOnly BirthDate, string CPF, DateTime CreatedAt, DateTime UpdatedAt, List<Review>? Review, List<Inventory>? Inventory, List<Address>? Address, List<Contact>? Contact);
}
