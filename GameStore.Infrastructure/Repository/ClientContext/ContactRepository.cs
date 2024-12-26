using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;
using GameStore.Infrastructure.Context;
using GameStore.Infrastructure.Repository.Base;


namespace GameStore.Infrastructure.Repository.ClientContext
{
    public class ContactRepository(AppDbContext context) : BaseRepository<Contact>(context), IContactRepository
    {
    }
}
