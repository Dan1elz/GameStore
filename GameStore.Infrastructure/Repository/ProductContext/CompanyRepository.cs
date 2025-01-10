using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;
using GameStore.Infrastructure.Context;
using GameStore.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infrastructure.Repository.ProductContext
{
    public class CompanyRepository(AppDbContext context) : BaseRepository<Company>(context), ICompanyRepository
    {
        public async override Task<Company?> GetByIdAsync(Guid Id, CancellationToken ct)
        {
            return await _context.Company
                .Include(c => c.Products)
                .FirstOrDefaultAsync(c => c.Id == Id, ct);
        }
    }
}
