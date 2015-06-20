using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Restaurant;

namespace SelfOrdering.Infra.Data.Repositories
{
    public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
    {
    }
}
