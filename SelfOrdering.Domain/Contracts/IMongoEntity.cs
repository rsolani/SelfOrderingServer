using MongoDB.Bson;

namespace SelfOrdering.Domain.Contracts
{
    public interface IMongoEntity
    {
        ObjectId Id { get; set; }
    }

}
