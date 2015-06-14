using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SelfOrdering.Domain.Models
{
    public class MenuItem : MongoEntityBase
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public IList<MenuItem> Suggestions { get; set; } 

        public byte[] SmallPicture { get; set; }
        public byte[] LargePicture { get; set; }
        
        [BsonRepresentation(BsonType.Double)]
        public decimal Price { get; set; }

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
