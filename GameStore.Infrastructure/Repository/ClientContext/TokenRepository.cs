using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;
using GameStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;


namespace GameStore.Infrastructure.Repository.ClientContext
{
    internal class TokenRepository(AppDbContext context) : ITokenRepository
    {
        private readonly AppDbContext _context = context;

        public virtual async Task Create(Token token, CancellationToken ct)
        {
            await _context.Token.AddAsync(token, ct);
            await _context.SaveChangesAsync(ct);
        }

        public virtual async Task Delete(Token token, CancellationToken ct)
        {
            _context.Token.Remove(token);
            await _context.SaveChangesAsync(ct);
        }

        public virtual async Task<Token?> GetToken(string value, CancellationToken ct)
        {
            return await _context.Token.SingleOrDefaultAsync(predicate: u => u.Value == value, ct);
        }

        public virtual async Task<Token?> GetTokenByID(Guid Id, CancellationToken ct)
        {
            return await _context.Token.SingleOrDefaultAsync(predicate: u => u.Id == Id, ct);
        }
    }
}
