using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using SelfOrdering.Domain.Contracts;
using SelfOrdering.Domain.Contracts.Repositories;

namespace SelfOrdering.Infra.Data
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : IMongoEntity
    {
        protected readonly DbContext<T> BaseConnectionHandler;
        
        protected BaseRepository()
        {
            BaseConnectionHandler = new DbContext<T>(); 
        }

        public async Task<T> Get(ObjectId id)
        {
            var filter = Builders<T>.Filter.Eq(x => x.Id, id);
            return await this.BaseConnectionHandler.Collection.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<IList<T>> Get()
        {
            return await this.BaseConnectionHandler.Collection.Find(new BsonDocument()).ToListAsync();
        }
        
        public async Task Insert(T entity)
        {
            await this.BaseConnectionHandler.Collection.InsertOneAsync(entity);
        }

        public async Task Update(T entity)
        {
            var filter = Builders<T>.Filter.Eq(x => x.Id, entity.Id);
            await this.BaseConnectionHandler.Collection.ReplaceOneAsync(filter, entity);
        }

        public async Task Delete(ObjectId id)
        {
            var filter = Builders<T>.Filter.Eq(x => x.Id, id);
            await this.BaseConnectionHandler.Collection.DeleteOneAsync(filter);
        }
    }
}
