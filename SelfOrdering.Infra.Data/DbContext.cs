using System.Configuration;
using System.Threading.Tasks;
using MongoDB.Driver;
using SelfOrdering.Domain.Contracts;
using SelfOrdering.Domain.Restaurant;

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

            //Cria index spatial no endereco do restaurante
            if (typeof (T).Name.ToLower() == "restaurant")
            {
                Task.Run(() =>
                {
                    var restaurantCollection = (IMongoCollection<Restaurant>) Collection;
                    var field = Builders<Restaurant>.IndexKeys.Geo2DSphere(x => x.Address.Location);
                    restaurantCollection.Indexes.CreateOneAsync(field);
                });
            }
        }
    }
}
