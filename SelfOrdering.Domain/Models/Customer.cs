using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SelfOrdering.Domain.Models
{
    public class Customer : MongoEntityBase
    {
        
        public string Name { get; set; }
        public string Cpf { get; set; }

        [BsonDateTimeOptions(DateOnly = true, Kind = DateTimeKind.Local, Representation = BsonType.DateTime)]
        public DateTime BirthDate { get; set; }

        [BsonIgnore]
        public int Age { get; set; }
        
        public IList<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}
