namespace GameStore.Aplication.DTOs.ClientContext.Client
{
    public record RequestCreateClientDTO(string Name, string LastName, string Email, string Password, DateOnly BirthDate, string CPF);
}
