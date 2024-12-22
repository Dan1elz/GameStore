namespace GameStore.Domain.DTOs.ClientContext.Client
{
    public record CreateClientDTO(string Name, string LastName, string Email, string Password, Date BirthDate, string CPF);
}