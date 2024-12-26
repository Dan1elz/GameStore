using GameStore.Domain.Enum;
namespace GameStore.Domain.DTOs.InteractionContext.Inventory
{
    public record CreateInventoryDTO(Guid ClientId, Guid ProductId, string Access, MethodAccess MethodAccess);
}
