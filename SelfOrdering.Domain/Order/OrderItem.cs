using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SelfOrdering.Domain.Order
{
    public class OrderItem
    {
        [BsonRepresentation(BsonType.Double)]
        public decimal Price { get; private set; }
    }
}