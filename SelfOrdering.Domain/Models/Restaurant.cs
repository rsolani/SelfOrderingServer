namespace SelfOrdering.Domain.Models
{
    public class Restaurant : MongoEntityBase
    {
        public string Name { get; set; }

        public int NumberOfTables { get; set; }

        public Menu Menu { get; set; }

        public Restaurant(string name, int numberOfTables)
        {
            Name = name;
            NumberOfTables = numberOfTables;
            Menu = new Menu();
        }
    }
    
}
