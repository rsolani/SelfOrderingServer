using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;
using SelfOrdering.Domain.Models;

namespace SelfOrdering.Domain.Services
{
    public class RestaurantService : DomainServiceBase<Restaurant>, IRestaurantService
    {
        private IBaseRepository<Restaurant> _repository;

        public RestaurantService(IBaseRepository<Restaurant> repository )
            : base(repository)
        {
            _repository = repository;
        }


    }
}
