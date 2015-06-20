using System.Collections.Generic;

namespace SelfOrdering.Domain.Restaurant
{
   
    public class MenuSection : MongoEntityBase
    {
        public string Name { get; private set; }
        public IList<MenuItem> Items {get; private set; }
        public IList<MenuSection> SubSections { get; private set; }

        public MenuSection(string name)
        {
            Name = name;
            Items = new List<MenuItem>();
            SubSections = new List<MenuSection>();
        }
    }

}
