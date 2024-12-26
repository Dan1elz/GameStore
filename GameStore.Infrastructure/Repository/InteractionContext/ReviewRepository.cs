using GameStore.Domain.Entities.InteractionContext;
using GameStore.Domain.Interfaces.Repository.InteractionContext;
using GameStore.Infrastructure.Context;
using GameStore.Infrastructure.Repository.Base;

namespace GameStore.Infrastructure.Repository.InteractionContext
{
    public class ReviewRepository(AppDbContext context) : BaseRepository<Review>(context), IReviewRepository
    {
    }
}
