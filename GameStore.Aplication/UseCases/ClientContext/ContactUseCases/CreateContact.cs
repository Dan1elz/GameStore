using GameStore.Aplication.DTOs.ClientContext.Contact;
using GameStore.Domain.DTOs.ClientContext.Contact;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.ContactUseCases
{
    public class CreateContact(IContactRepository repository)
    {
        public readonly IContactRepository _repository = repository;

        public async Task Execute(RequestCreateContactDTO contact, Token token, CancellationToken ct)
        {
            Contact newContact = new(new CreateContactDTO(token.Client, contact.Description, contact.PhoneNumber, contact.Email));
            await _repository.AddAsync(newContact, ct);
        }
    }
}