namespace GameStore.Domain.DTOs.ProductContext.Company
{

    #nullable enable
    public record CreateCompanyDTO(string Name, string CNPJ, string? Email);
}
