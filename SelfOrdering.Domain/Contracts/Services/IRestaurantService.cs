using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using SelfOrdering.Domain.Restaurant;

namespace SelfOrdering.Domain.Contracts.Services
{
    public interface IRestaurantService : IDomainService<Restaurant.Restaurant>
    {
        Task<IEnumerable<Table>> GetAllTables(ObjectId restaurantId);
        Task<Table> GetTable(ObjectId restaurantId, ObjectId tableId);
        Task SetTableOccupation(ObjectId restaurantId, ObjectId tableId, bool isOccupied);
    }
}
