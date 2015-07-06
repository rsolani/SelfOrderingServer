using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.Domain.Contracts.Repositories;

namespace SelfOrdering.ApplicationServices.Order
{
    public class OrderApplicationService : ApplicationServiceBase<Domain.Order.Order>, IOrderApplicationService
    {
        public OrderApplicationService(IBaseRepository<Domain.Order.Order> repository) 
            : base(repository)
        {
            
        }
    }
}
