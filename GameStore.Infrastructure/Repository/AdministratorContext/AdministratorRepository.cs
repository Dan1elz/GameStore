using GameStore.Infrastructure.Context;
using GameStore.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;
using GameStore.Domain.Entities.AdministratorContext;
using GameStore.Domain.Interfaces.Repository.AdministratorContext;

namespace GameStore.Infrastructure.Repository.AdministratorContext
{
    public class AdministratorRepository(AppDbContext context) : BaseRepository<Administrator>(context), IAdministratorRepository
    {
        public virtual async Task<Administrator?> Login(string Email, string Password, CancellationToken ct)
        {
            return await _context.Administrator.SingleOrDefaultAsync(predicate: u => u.Email == Email && u.Password == Password, ct);
        }

        public virtual async Task<Administrator?> GetAdministratorByID(Guid id, CancellationToken ct)
        {
            return await _context.Administrator.SingleOrDefaultAsync(predicate: u => u.Id == id, ct);
        }
    }
}

