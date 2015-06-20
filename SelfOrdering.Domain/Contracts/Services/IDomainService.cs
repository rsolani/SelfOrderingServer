using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace SelfOrdering.Domain.Contracts.Services
{
    public interface IDomainService<T> where T : IMongoEntity, IAggregateRoot
    {

    }
}
