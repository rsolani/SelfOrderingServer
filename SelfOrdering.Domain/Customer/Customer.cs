using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using SelfOrdering.CrossCutting.Validation;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.Domain.Customer
{
    public class Customer : MongoEntityBase, IAggregateRoot
    {
        public enum LoginType
        {
            Facebook = 1,
            Google = 2
        }

        
        public string Name { get; set; }
        public string Cpf { get; set; }

        public string Email { get; set; }

        public string UserImageUrl { get; set; }
        
        [BsonDateTimeOptions(DateOnly = true, Kind = DateTimeKind.Utc, Representation = BsonType.DateTime)]
        public DateTime BirthDate { get; private set; }

        public LoginType LoginProvider { get; private set; }

        [BsonIgnore]
        public int Age
        {
            get { return DateTime.Now.Year - BirthDate.Year; }
        }
        
        //public IList<Order.Order> Orders { get; set; }

        public Customer(string name, string email, string cpf)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
            Validate();
        }

        public override void Validate()
        {
            AssertionConcern.AssertArgumentNotNull(Name, "Name cannot be null.");
            AssertionConcern.AssertArgumentNotEmpty(Name, "Name cannot be a empty string");

            EmailAssertionConcern.AssertIsValid(Email);

            if (!String.IsNullOrEmpty(Cpf))
                CpfAssertionConcern.AssertIsValid(Cpf);

        }

    }
}
