using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MongoDB.Bson;
using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.ApplicationServices.DTO;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.ApplicationServices.Restaurant
{
    public class RestaurantApplicationService : ApplicationServiceBase<Domain.Restaurant.Restaurant>, IRestaurantApplicationService
    {
        private readonly IRestaurantService _restaurantService;
     
        public RestaurantApplicationService(IBaseRepository<Domain.Restaurant.Restaurant> repository, 
            IRestaurantService restaurantService) 
            : base(repository)
        {
            _restaurantService = restaurantService;
        }

        public async Task<IReadOnlyList<RestaurantDTO>> GetAll()
        {
            var entity = await Repository.GetAllAsync();
            return Mapper.Map(entity, new List<RestaurantDTO>());
        }

        public async Task<RestaurantDTO> GetById(string id)
        {
            var entity = await Repository.GetByIdAsync(new ObjectId(id));
            return Mapper.Map(entity, new RestaurantDTO());
        }
    }
}
