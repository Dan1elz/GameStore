using GameStore.Domain.Entities.AdministratorContext;
using GameStore.Domain.Interfaces.Repository.AdministratorContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;

namespace GameStore.Aplication.UseCases.ProductContext.CompanyUseCases
{
    public class RemoveCompany(ICompanyRepository repository, IAdministratorRepository administratorRepository)
    {
        public readonly ICompanyRepository _repository = repository;
        public readonly IAdministratorRepository _administratorRepository = administratorRepository;

        public async Task Execute(Guid Id, AdministratorToken token, CancellationToken ct)
        {
            var admin = await _administratorRepository.GetAdministratorByID(token.AdministratorId, ct);
            if (admin != null)
                throw new Exception("Administrator can't create category");

            var company = await _repository.GetByIdAsync(Id, ct) ?? throw new Exception("Company not found");

            if (company.Products.Count != 0)
                throw new Exception("Company has products");

            await _repository.Remove(company, ct);
        }
    }
}
