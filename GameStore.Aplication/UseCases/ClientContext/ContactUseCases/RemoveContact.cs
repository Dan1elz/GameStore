using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.ContactUseCases
{
    public class RemoveContact(IContactRepository repository)
    {
        private readonly IContactRepository _repository = repository;
        
        public async Task Execute(Guid Id, Token token, CancellationToken ct)
        {
            var contact = await _repository.GetAsync(entity => entity.Id == Id && entity.ClientId == token.ClientId, ct) ?? throw new Exception("Contact not found");
            await _repository.Remove(contact, ct);
        }
    }
}
