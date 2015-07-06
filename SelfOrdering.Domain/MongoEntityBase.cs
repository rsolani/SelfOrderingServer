using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.Domain
{
    public abstract class MongoEntityBase : IMongoEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        protected MongoEntityBase()
        {
            Id = ObjectId.GenerateNewId();
        }
    }
}
