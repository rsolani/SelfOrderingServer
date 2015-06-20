using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.Domain.Order
{
    public class OrderService : DomainServiceBase<Order>, ICustomerService
    {

        public OrderService(IBaseRepository<Order> repository)
            : base(repository)
        {
            
        }
    }
}
