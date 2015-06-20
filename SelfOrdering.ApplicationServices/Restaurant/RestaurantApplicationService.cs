using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.ApplicationServices.Restaurant
{
    public class RestaurantApplicationService : ApplicationServiceBase<Domain.Restaurant.Restaurant>, IRestaurantApplicationService
    {
        public RestaurantApplicationService(IBaseRepository<Domain.Restaurant.Restaurant> repository, 
                                                IDomainService<Domain.Restaurant.Restaurant> domainService) 
            : base(repository, domainService)
        {
            
        }
    }
}
