using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SelfOrdering.Domain.Restaurant
{
    public class MenuItem : MongoEntityBase
    {
        public string Name { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; set; }

        public IList<MenuItem> Suggestions { get; set; } 

        public byte[] SmallPicture { get; set; }
        public byte[] LargePicture { get; set; }
        
        [BsonRepresentation(BsonType.Double)]
        public decimal Price { get; private set; }

        [BsonIgnore]
        public bool RestrictedByCustomerAge { get; set; }

        public MenuItem(string name, string shortDescrption, decimal price)
        {
            Name = name;
            ShortDescription = shortDescrption;
            Price = price;
            Suggestions = new List<MenuItem>();
        }
    }

}
