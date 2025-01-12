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
    public class GetCompanyDetailsByProduct(ICompanyRepository repository, IProductRepository productRepository, GetAllProductsByCompany service)
    {
        private readonly ICompanyRepository _repository = repository;
        private readonly IProductRepository _productRepository = productRepository;
        private readonly GetAllProductsByCompany _service = service;

        public async Task<ReturnCompanyDetailsDTO> Execute(Guid productId, CancellationToken ct)
        {
            var product = await _productRepository.GetByIdAsync(productId, ct) ?? throw new Exception("Product not found");
            var company = await _repository.GetByIdAsync(product.CompanyId, ct) ?? throw new Exception("Company not found");
            var products = await _service.Execute(company.Id, 0, 10, ct);

            return new ReturnCompanyDetailsDTO
            {
                Company = company,
                Products = (DTOs.ProductContext.Products.ReturnProductsWithRating)products
            };
        }
    }
}
