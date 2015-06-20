using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Order;

namespace SelfOrdering.Infra.Data.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
    }
}
