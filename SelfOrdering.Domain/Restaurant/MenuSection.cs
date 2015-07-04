using System;
using System.Collections;
using System.Collections.Generic;

namespace SelfOrdering.Domain.Restaurant
{
    public class MenuSection : MongoEntityBase
    {
        public string Name { get; private set; }
        public IReadOnlyCollection<MenuItem> Items { get; private set; }
        public IReadOnlyCollection<MenuSection> SubSections { get; private set; }

        public MenuSection(string name)
        {
            Name = name;
            Items = new List<MenuItem>();
            SubSections = new List<MenuSection>();
        }
        
        public void AddItem(MenuItem item)
        {
            if (item == null)
                throw new ArgumentNullException("AddItem: SubItem cannot be null");

            ((IList)Items).Add(item);
        }

        public void RemoveItem(MenuItem item)
        {
            if (item == null)
                throw new ArgumentNullException("AddSubItem: SubItem cannot be null");

            ((IList)Items).Remove(item);
        }

        public void AddSubSection(MenuSection subSection)
        {
            if (subSection == null)
                throw new ArgumentNullException("AddSubSection: subSection cannot be null");

            ((IList)SubSections).Add(subSection);
        }

        public void RemoveSubSection(MenuSection subSection)
        {
            if (subSection == null)
                throw new ArgumentNullException("RemoveSubSection: subSection cannot be null");

            ((IList)SubSections).Remove(subSection);
        }


    }

}
