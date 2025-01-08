using GameStore.Domain.Entities.AdministratorContext;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.AdministratorContext;
using GameStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infrastructure.Repository.AdministratorContext
{
    public class AdministratorTokenRepository(AppDbContext context) : IAdministratorTokenRepository
    {
        private readonly AppDbContext _context = context;

        public virtual async Task Create(AdministratorToken token)
        {
            await _context.AdministratorToken.AddAsync(token);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Delete(AdministratorToken token)
        {
            _context.AdministratorToken.Remove(token);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<AdministratorToken?> GetToken(string value)
        {
            return await _context.AdministratorToken.SingleOrDefaultAsync(predicate: u => u.Value == value);
        }

        public virtual async Task<AdministratorToken?> GetTokenByID(Guid Id)
        {
            return await _context.AdministratorToken.SingleOrDefaultAsync(predicate: u => u.Id == Id);
        }
    }
}
