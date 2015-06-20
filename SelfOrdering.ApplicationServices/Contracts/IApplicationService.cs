using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.ApplicationServices.Contracts
{
    public interface IApplicationService<T> where T : IMongoEntity , IAggregateRoot
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(ObjectId id);
    }
}
