using System;
using System.Collections;
using System.Collections.Generic;

namespace SelfOrdering.Domain.Restaurant
{
    public class Menu : MongoEntityBase
    {
        public string Name { get; set; }
        public IReadOnlyCollection<MenuSection> MenuSections { get; private set; }

        public Menu()
        {
            MenuSections = new List<MenuSection>();
        }

        public void AddSection(MenuSection section)
        {
            if (section == null)
                throw new ArgumentNullException("AddSection: Section cannot be null");
            
            ((IList)MenuSections).Add(section);
        }

        public void RemoveSection(MenuSection section)
        {
            if (section == null)
                throw new ArgumentNullException("RemoveSection: Section cannot be null");

            ((IList)MenuSections).Remove(section);
        }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
