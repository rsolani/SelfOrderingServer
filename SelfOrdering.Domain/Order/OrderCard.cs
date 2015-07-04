using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SelfOrdering.Domain.Restaurant;

namespace SelfOrdering.Domain.Order
{
    public class OrderCard : MongoEntityBase
    {
        public ObjectId RestaurantId { get; private set; }
        public ObjectId TableId { get; private set; }
        public ObjectId CustomerId { get; private set; }

        public IReadOnlyCollection<MenuItem> Items { get; private set; }
        
        public OrderCard(ObjectId restaurantId, ObjectId tableId, ObjectId customerId)
        {
            RestaurantId = restaurantId;
            TableId = tableId;
            CustomerId = customerId;

            Items = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {
            ((IList)Items).Add(item);
        }
        public void RemoveItem(MenuItem item)
        {
            ((IList)Items).Add(item);
        }

        [BsonIgnore]
        public decimal OrderCardTotal
        {
            get { return Items.Sum(x => x.Price); }
        }
    }
}