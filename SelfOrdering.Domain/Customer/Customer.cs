using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.Domain.Customer
{
    public class Customer : MongoEntityBase, IAggregateRoot
    {
        
        public string Name { get; set; }
        public string Cpf { get; set; }

        [BsonDateTimeOptions(DateOnly = true, Kind = DateTimeKind.Utc, Representation = BsonType.DateTime)]
        public DateTime BirthDate { get; set; }
        
        [BsonIgnore]
        public int Age
        {
            get { return DateTime.Now.Year - BirthDate.Year; }
        }
        
        public IList<Order.Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order.Order>();
        }
    }
}
