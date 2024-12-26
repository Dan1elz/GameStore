using GameStore.Domain.Entities.InteractionContext;
using GameStore.Domain.Interfaces.Repository.InteractionContext;
using GameStore.Infrastructure.Context;
using GameStore.Infrastructure.Repository.Base;

namespace GameStore.Infrastructure.Repository.InteractionContext
{
    public class InventoryRepository(AppDbContext context) : BaseRepository<Inventory>(context), IInventoryRepository
    {
    }
}
