namespace GameStore.Domain.DTOs.ProductContext.Company
{
    #nullable enable
    public record UpdateCompanyDTO(string Name, string CNPJ, string? Email);
}
