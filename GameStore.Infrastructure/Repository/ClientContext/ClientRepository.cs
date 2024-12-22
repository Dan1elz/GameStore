using GameStore.Domain.Interfaces.Repository.ClientContext;
using GameStore.Infrastructure.Repository.Base;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infrastructure.Repository.ClientContext
{
    public class ClientRepository(AppDbContext context) : BaseRepository<Client>(context), IClientRepository
    {
        public virtual async Task<Client?> Login(string Email, string Password)
        {
            return await _context.Client.SingleOrDefaultAsync(predicate: u => u.Email == Email && u.Password == Password);
        }
    }
}
