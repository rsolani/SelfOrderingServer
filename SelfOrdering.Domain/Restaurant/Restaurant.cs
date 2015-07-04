using System;
using System.Collections;
using System.Collections.Generic;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.Domain.Restaurant
{
    public class Restaurant : MongoEntityBase, IAggregateRoot
    {
        public string Name { get;  set; }

        public Address Address { get; set; }

        public int TotalNumberOfTables { get; set; }

        public Menu Menu { get; set; }

        public IReadOnlyCollection<Table> Tables { get; private set; }

        public Restaurant(string name, Address address, int totalNumberOfTables)
        {
            Name = name;
            Address = address;
            TotalNumberOfTables = totalNumberOfTables;
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
    }
}
