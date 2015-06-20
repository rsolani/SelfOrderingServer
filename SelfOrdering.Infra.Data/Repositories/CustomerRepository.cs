using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Customer;
using SelfOrdering.Domain.Order;

namespace SelfOrdering.Infra.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
    }
}
