using GameStore.Aplication.DTOs.ClientContext.Client;

namespace GameStore.Aplication.Mappers.ClientContext.Client
{
    public class MapClientToReturnGetClientDTO
    {
        public static ReturnGetClientDTO Execute(Domain.Entities.ClientContext.Client client)
        {
            return new ReturnGetClientDTO(client.Id, client.Name, client.LastName, client.Email, client.BirthDate, client.CPF, client.CreatedAt, client.UpdatedAt, [.. client.Reviews], [.. client.Inventoryes], [.. client.Addresses], [.. client.Contacts]);
        }
    }
}
