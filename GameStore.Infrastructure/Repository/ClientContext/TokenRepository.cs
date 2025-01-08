using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;
using GameStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;


namespace GameStore.Infrastructure.Repository.ClientContext
{
    internal class TokenRepository(AppDbContext context) : ITokenRepository
    {
        private readonly AppDbContext _context = context;

        public virtual async Task Create(Token token)
        {
            await _context.Token.AddAsync(token);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Delete(Token token)
        {
            _context.Token.Remove(token);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<Token?> GetToken(string value)
        {
            return await _context.Token.SingleOrDefaultAsync(predicate: u => u.Value == value);
        }

        public virtual async Task<Token?> GetTokenByID(Guid Id)
        {
            return await _context.Token.SingleOrDefaultAsync(predicate: u => u.Id == Id);
        }
    }
}
