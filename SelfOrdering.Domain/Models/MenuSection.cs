using System.Collections.Generic;

namespace SelfOrdering.Domain.Models
{
   
    public class MenuSection : MongoEntityBase
    {
        public string Name { get; set; }
        public IList<MenuItem> Items {get; set; }
        public IList<MenuSection> SubSections { get; set; }

        public MenuSection(string name)
        {
            
            Name = name;
            Items = new List<MenuItem>();
            SubSections = new List<MenuSection>();
        }
    }

}
