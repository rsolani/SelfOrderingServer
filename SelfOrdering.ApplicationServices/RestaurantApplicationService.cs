using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.Domain.Contracts.Services;
using SelfOrdering.Domain.Models;

namespace SelfOrdering.ApplicationServices
{
    public class RestaurantApplicationService : ApplicationServiceBase<Restaurant>, IRestaurantApplicationService
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantApplicationService(IRestaurantService restaurantService) : base(restaurantService)
        {
            _restaurantService = restaurantService;
        }

   
    }
}
