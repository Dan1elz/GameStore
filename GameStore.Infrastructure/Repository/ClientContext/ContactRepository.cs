using GameStore.Domain.Interfaces.Repository.ClientContext;
using GameStore.Infrastructure.Repository.Base;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Infrastructure.Context;


namespace GameStore.Infrastructure.Repository.ClientContext
{
    public class ContactRepository(AppDbContext context) : BaseRepository<Contact>(context), IContactRepository
    {
    }
}
