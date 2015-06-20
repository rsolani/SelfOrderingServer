using System;
using System.Threading.Tasks;
using MongoDB.Bson;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.Domain.Order
{
    public class OrderService : DomainServiceBase<Order>, IOrderService
    {

        public OrderService(IBaseRepository<Order> repository)
            : base(repository)
        {
            
        }

        public async Task<Order> CreateOrder(ObjectId restaurantId, ObjectId tableId, ObjectId customerId)
        {
            Order order = new Order(restaurantId, tableId, customerId);

            order.AddCard(new OrderCard(restaurantId, tableId, customerId));

            await Repository.InsertAsync(order);

            return order;
        }
    }
}
