﻿using System.Threading.Tasks;
using MongoDB.Bson;

namespace SelfOrdering.Domain.Contracts.Services
{
    public interface IOrderService : IDomainService<Order.Order>
    {
        Task<Order.Order> CreateOrder(ObjectId restaurantId, ObjectId tableId, ObjectId customerId);
    }
}
