using System;
using System.Collections;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.Domain.Restaurant
{
    public class Restaurant : MongoEntityBase, IAggregateRoot
    {
        public string Name { get;  private set; }

        public string Type { get; private set; }

        public Address Address { get; private set; }
        
        [BsonIgnore]
        public int TotalNumberOfTables
        {
            get { return Tables.Count; }
        }

        public Menu Menu { get; set; }

        public IReadOnlyCollection<Table> Tables { get; private set; }

        public Restaurant(string name, string type, Address address)
        {
            Name = name;
            Type = type;
            Address = address;
            Menu = new Menu();
            Tables = new List<Table>();
        }

        public void AddTable(Table table)
        {
            if (table == null)
                throw new ArgumentNullException("AddTable: SubItem cannot be null");

            ((IList)Tables).Add(table);
        }

        public void RemoveTable(Table table)
        {
            if (table == null)
                throw new ArgumentNullException("RemoveTable: SubItem cannot be null");

            ((IList)Tables).Remove(table);
        }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
