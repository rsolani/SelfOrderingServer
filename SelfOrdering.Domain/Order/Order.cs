using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.Domain.Order
{
    public class Order : MongoEntityBase, IAggregateRoot
    {
        public ObjectId RestaurantId { get; set; }

        public ObjectId TableId{ get; set; }

        public IList<OrderItem> Items { get; set; }

        [BsonDateTimeOptions(DateOnly = false, Kind = DateTimeKind.Utc, Representation = BsonType.DateTime)]
        public DateTime DateTimeOrderWasMade { get; private set; }

        public decimal Total
        {
            get { return Items.Sum(x => x.Price); }
        }
        

        public Order(ObjectId tableId, DateTime datetimeOrderWasMade)
        {
            DateTimeOrderWasMade = datetimeOrderWasMade;
            TableId = tableId;
            Items = new List<OrderItem>();
        }
    }
}
