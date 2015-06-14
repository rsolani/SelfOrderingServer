using System.Configuration;
using MongoDB.Driver;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.Infra.Data
{
    public class DbContext<T> where T : IMongoEntity
    {
        private const string MONGODB_DATABASENAME = "SelfOrdering";
        
        public IMongoCollection<T> Collection { get; private set; }

        public DbContext()
        {
            var client = new MongoClient(ConfigurationManager.ConnectionStrings["SelfOrderingMongoDB"].ConnectionString);
            
            var db = client.GetDatabase(MONGODB_DATABASENAME);
            
            Collection = db.GetCollection<T>(typeof(T).Name);
        }
    }
}
