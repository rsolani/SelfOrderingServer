using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.ApplicationServices.Order
{
    public class OrderApplicationService : ApplicationServiceBase<Domain.Order.Order>, IOrderApplicationService
    {
        public OrderApplicationService(IBaseRepository<Domain.Order.Order> repository, 
                                                IDomainService<Domain.Order.Order> domainService) 
            : base(repository, domainService)
        {
            
        }
    }
}
