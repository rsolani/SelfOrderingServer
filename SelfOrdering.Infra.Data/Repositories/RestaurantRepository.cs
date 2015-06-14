using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Models;

namespace SelfOrdering.Infra.Data.Repositories
{
    public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository()
        {
                
        }
    }
}
