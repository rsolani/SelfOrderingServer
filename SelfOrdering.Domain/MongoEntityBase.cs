using System;
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

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        protected MongoEntityBase()
        {
            Id = ObjectId.GenerateNewId();
            Created = DateTime.Now;
        }


        public abstract void Validate();

    }
}
