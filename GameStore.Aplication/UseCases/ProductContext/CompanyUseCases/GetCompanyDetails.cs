using GameStore.Aplication.DTOs.ProductContext.Company;
using GameStore.Aplication.UseCases.ProductContext.ProductContext;
using GameStore.Domain.Interfaces.Repository.ProductContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Aplication.UseCases.ProductContext.CompanyUseCases
{
    public class GetCompanyDetails(ICompanyRepository repository, GetAllProductsByCompany service)
    {
        private readonly ICompanyRepository _repository = repository;
        private readonly GetAllProductsByCompany _service = service;

        public async Task<ReturnCompanyDetailsDTO> Execute(Guid companyId, CancellationToken ct)
        {
            var company =  await _repository.GetByIdAsync(companyId, ct) ?? throw new Exception("Company not found");
            var products = await _service.Execute(company.Id , 0, 10, ct);

            return new ReturnCompanyDetailsDTO
            {
                Company = company,
                Products = (DTOs.ProductContext.Products.ReturnProductsWithRating)products
            };
        }
    }
}
