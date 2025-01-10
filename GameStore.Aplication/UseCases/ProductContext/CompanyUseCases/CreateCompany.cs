using GameStore.Domain.Entities.AdministratorContext;
using GameStore.Domain.Interfaces.Repository.AdministratorContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;
using GameStore.Domain.Entities.ProductContext;
using GameStore.Aplication.DTOs.ProductContext.Company;
using GameStore.Domain.DTOs.ProductContext.Company;

namespace GameStore.Aplication.UseCases.ProductContext.CompanyUseCases
{
    internal class CreateCompany(ICompanyRepository repository, IAdministratorRepository administratorRepository)
    {
        public readonly ICompanyRepository _repository = repository;
        public readonly IAdministratorRepository _administratorRepository = administratorRepository;

        public async Task Execute(RequestCreateCompanyDTO company, AdministratorToken token, CancellationToken ct)
        {
            var admin = await _administratorRepository.GetAdministratorByID(token.AdministratorId, ct);
            if (admin != null)
                throw new Exception("Administrator can't create category");

            Company companyEntity = new(new CreateCompanyDTO(company.Name, company.CNPJ, company.Email));
            await _repository.AddAsync(companyEntity, ct);
        }
    }
}
