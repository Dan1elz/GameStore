using GameStore.Domain.Entities.AdministratorContext;
using GameStore.Domain.Interfaces.Repository.AdministratorContext;
using GameStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infrastructure.Repository.AdministratorContext
{
    public class AdministratorTokenRepository(AppDbContext context) : IAdministratorTokenRepository
    {
        private readonly AppDbContext _context = context;

        public virtual async Task Create(AdministratorToken token, CancellationToken ct)
        {
            await _context.AdministratorToken.AddAsync(token, ct);
            await _context.SaveChangesAsync(ct);
        }

        public virtual async Task Delete(AdministratorToken token, CancellationToken ct)
        {
            _context.AdministratorToken.Remove(token);
            await _context.SaveChangesAsync(ct);
        }

        public virtual async Task<AdministratorToken?> GetToken(string value, CancellationToken ct)
        {
            return await _context.AdministratorToken.SingleOrDefaultAsync(predicate: u => u.Value == value, ct);
        }

        public virtual async Task<AdministratorToken?> GetTokenByID(Guid Id, CancellationToken ct)
        {
            return await _context.AdministratorToken.SingleOrDefaultAsync(predicate: u => u.Id == Id, ct);
        }
    }
}
