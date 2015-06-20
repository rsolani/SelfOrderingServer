using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.Domain.Restaurant
{
    public class RestaurantService : DomainServiceBase<Restaurant>, IRestaurantService
    {
        public RestaurantService(IBaseRepository<Restaurant> repository)
            : base(repository)
        {
            
        }

        public async Task<IEnumerable<Table>> GetAllTables(ObjectId restaurantId)
        {
            var rest = await Repository.GetByIdAsync(restaurantId);

            return rest.Tables;
        }

        public async Task<Table> GetTable(ObjectId restaurantId, ObjectId tableId)
        {
            if(restaurantId == null)
                throw new ArgumentNullException("GetTable : restaurantId null");

            if (tableId == null)
                throw new ArgumentNullException("GetTable : tableId null");            

            var rest = await Repository.GetByIdAsync(restaurantId);
            var table = rest.Tables.FirstOrDefault(x => x.Id == tableId);

            if (table == null)
                throw new ArgumentNullException(String.Format("GetTable:TableId {0} not found", tableId.ToString()));            
            
            return table;
        }

        public async Task SetTableOccupation(ObjectId restaurantId, ObjectId tableId, bool isOccupied)
        {
            if (restaurantId == null)
                throw new ArgumentNullException("SetTableOccupation : restaurantId null");

            if (tableId == null)
                throw new ArgumentNullException("SetTableOccupation : tableId null"); 

            var table = await this.GetTable(restaurantId, tableId);

            table.SetOccupation(isOccupied);
            
            var filter = FilterBuilder.Eq("Tables._id", table.Id);
            var update = UpdateBuilder.Set("Tables.$", table);

            var r = await Repository.UpdateAsync(filter, update);
        }
    }
}
