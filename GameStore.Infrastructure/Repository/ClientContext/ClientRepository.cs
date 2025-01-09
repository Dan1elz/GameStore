using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;
using GameStore.Infrastructure.Context;
using GameStore.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infrastructure.Repository.ClientContext
{
    public class ClientRepository(AppDbContext context) : BaseRepository<Client>(context), IClientRepository
    {
        public virtual async Task<Client?> Login(string Email, string Password, CancellationToken ct)
        {
            return await _context.Client.SingleOrDefaultAsync(predicate: u => u.Email == Email && u.Password == Password, ct);
        }
        public virtual async Task<Client?> VerifyEmail(string Email, CancellationToken ct)
        {
            return await _context.Client.SingleOrDefaultAsync(predicate: u => u.Email == Email, ct);
        }
        public async override Task<Client?> GetByIdAsync(Guid Id, CancellationToken ct)
        {
            return await _context.Client
                .Include(c => c.Addresses)
                .Include(c => c.Contacts)
                .Include(c => c.Reviews)
                .Include(c => c.Inventoryes)
                .FirstOrDefaultAsync(c => c.Id == Id, ct);
        }
        public async override Task Remove(Client entity, CancellationToken ct)
        {
            foreach (var favorite in entity.Favorites.ToList())
            {
                _context.Favorite.Remove(favorite);
            }

            foreach (var review in entity.Reviews.ToList())
            {
                _context.Review.Remove(review);
            }

            foreach (var cart in entity.Carts.ToList())
            {
                _context.Cart.Remove(cart);
            }

            foreach (var address in entity.Addresses.ToList())
            {
                _context.Address.Remove(address);
            }

            foreach (var contact in entity.Contacts.ToList())
            {
                _context.Contact.Remove(contact);
            }

            _context.Client.Remove(entity);
            await _context.SaveChangesAsync(ct);
        }
    }
}
