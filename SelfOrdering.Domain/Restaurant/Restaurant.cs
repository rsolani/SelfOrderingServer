using System.Collections.Generic;
using SelfOrdering.Domain.Contracts;

namespace SelfOrdering.Domain.Restaurant
{
    public class Restaurant : MongoEntityBase, IAggregateRoot
    {
        public string Name { get; private set; }

        public int TotalNumberOfTables { get; private set; }

        public Menu Menu { get; set; }

        public IList<Table> Tables { get; set; }

        public Restaurant(string name, int totalNumberOfTables)
        {
            Name = name;
            TotalNumberOfTables = totalNumberOfTables;
            Menu = new Menu();
            Tables = new List<Table>();
        }
    }
    
}
