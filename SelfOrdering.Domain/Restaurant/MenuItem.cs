using System;
using System.Collections;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SelfOrdering.Domain.Restaurant
{
    public class MenuItem : MongoEntityBase
    {
        public string Name { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; set; }

        public IReadOnlyCollection<MenuItem> SubItems { get; private set; }

        public IReadOnlyCollection<MenuItem> Suggestions { get; private set; }
        
        public byte[] SmallPicture { get; set; }
        public byte[] LargePicture { get; set; }
        
        [BsonRepresentation(BsonType.Double)]
        public decimal Price { get; private set; }

        public bool IsActive { get; private set; }
        
        public bool IsRestrictedByCustomerAge { get; private set; }

        public MenuItem(string name, string shortDescription, decimal price, bool isActive, bool isRestrictedByCustomerAge)
        {
            Name = name;
            ShortDescription = shortDescription;
            Price = price;
            IsActive = isActive;
            IsRestrictedByCustomerAge = isRestrictedByCustomerAge;
            SubItems = new List<MenuItem>();
            Suggestions = new List<MenuItem>();
        }

        public void SetActive(bool isActive)
        {
            IsActive = isActive;
        }

        public void AddSubItem(MenuItem subItem)
        {
            if (subItem == null)
                throw new ArgumentNullException("AddSubItem: SubItem cannot be null");
            
            ((IList)SubItems).Add(subItem);
        }

        public void RemoveSection(MenuItem subItem)
        {
            if (subItem == null)
                throw new ArgumentNullException("AddSubItem: SubItem cannot be null");

            ((IList)SubItems).Remove(subItem);
        }

        public void AddSuggestion(MenuItem suggestion)
        {
            if (suggestion == null)
                throw new ArgumentNullException("AddSuggestion: suggestion cannot be null");

            ((IList)Suggestions).Add(suggestion);
        }

        public void RemoveSuggestion(MenuItem suggestion)
        {
            if (suggestion == null)
                throw new ArgumentNullException("RemoveSuggestion: suggestion cannot be null");

            ((IList)Suggestions).Remove(suggestion);
        }
    }
}
