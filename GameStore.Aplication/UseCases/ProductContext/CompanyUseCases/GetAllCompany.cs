using GameStore.Domain.Entities.ProductContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;

namespace GameStore.Aplication.UseCases.ProductContext.CompanyUseCases
{
    public class GetAllCompany(ICompanyRepository repository)
    {
        private readonly ICompanyRepository _repository = repository;

        public async Task<IEnumerable<Company>> Execute(int offset, int limit, CancellationToken ct)
        {
            return await _repository.GetAllAsync(enity => true, offset, limit, ct);
        }
    }
}
