using GameStore.Aplication.DTOs.ClientContext.Contact;
using GameStore.Domain.DTOs.ClientContext.Contact;
using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.ContactUseCases
{
    public class UpdateContact(IContactRepository repository)
    {
        public readonly IContactRepository _repository = repository;

        public async Task Execute(RequestUpdateContactDTO _contact, Token token, Guid Id, CancellationToken ct)
        {
            var contact = await _repository.GetAsync(entity => entity.Id == Id && entity.ClientId == token.ClientId, ct) ?? throw new Exception("Contact not found");
            contact.Update(new UpdateContactDTO(_contact.Description, _contact.PhoneNumber, _contact.Email));
            await _repository.AddAsync(contact, ct); 
        }
    }
}
