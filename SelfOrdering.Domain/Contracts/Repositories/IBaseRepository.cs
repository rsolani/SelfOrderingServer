using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace SelfOrdering.Domain.Contracts.Repositories
{
    public interface IBaseRepository<T> where T : IMongoEntity
    {
        Task<T> Get(ObjectId id);

        Task<IList<T>> Get();

        Task Insert(T entity);

        Task Update(T entity);

        Task Delete(ObjectId id);
    }
}
