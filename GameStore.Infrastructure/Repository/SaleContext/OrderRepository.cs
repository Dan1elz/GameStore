using GameStore.Domain.Entities.SaleContext;
using GameStore.Domain.Interfaces.Repository.SaleContext;
using GameStore.Infrastructure.Context;
using GameStore.Infrastructure.Repository.Base;

namespace GameStore.Infrastructure.Repository.SaleContext
{
    public class OrderRepository(AppDbContext context) : BaseRepository<Order>(context), IOrderRepository
    {
    }
}
