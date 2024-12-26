using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Enum;
namespace GameStore.Domain.DTOs.InteractionContext.Inventory
{
    public record CreateInventoryDTO(Client Client, Product Product, string Access, MethodAccess MethodAccess);
}
