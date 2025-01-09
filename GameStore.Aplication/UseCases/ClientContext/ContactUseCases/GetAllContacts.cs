using GameStore.Domain.Entities.ClientContext;
using GameStore.Domain.Interfaces.Repository.ClientContext;

namespace GameStore.Aplication.UseCases.ClientContext.ContactUseCases
{
    public class GetAllContacts(IContactRepository repository)
    {
        public readonly IContactRepository _repository = repository;

        public async Task<IEnumerable<Contact>> Execute(Token token, CancellationToken ct)
        {
            return await _repository.GetAllAsync(entity => entity.ClientId == token.ClientId, ct);
        }
    }
}
