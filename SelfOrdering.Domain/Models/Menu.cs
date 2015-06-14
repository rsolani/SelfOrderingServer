using System.Collections.Generic;

namespace SelfOrdering.Domain.Models
{
    public class Menu : MongoEntityBase
    {
        public string Name { get; set; }
        public IList<MenuSection> MenuSections { get; set; }

        public Menu()
        {
            MenuSections = new List<MenuSection>();
        }
    }
}
