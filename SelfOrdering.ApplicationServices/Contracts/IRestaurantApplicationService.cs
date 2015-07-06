using System.Collections.Generic;
using System.Threading.Tasks;
using SelfOrdering.ApplicationServices.Restaurant;

namespace SelfOrdering.ApplicationServices.Contracts
{
    public interface IRestaurantApplicationService : IApplicationService
    {
        Task<IReadOnlyList<RestaurantDTO>> GetAll();
        Task<RestaurantDTO> GetById(string id);
        Task<IEnumerable<RestaurantDTO>> GetNearRestaurants(double longitude, double latitude);
    }
}
