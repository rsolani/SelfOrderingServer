using System.Collections.Generic;

namespace SelfOrdering.Domain.Models
{
    public class Order : MongoEntityBase
    {
        public string Name { get; set; }

        public Restaurant Restaurant { get; set; }

        public IList<MenuItem> Items { get; set; }

        public Order()
        {
            Items = new List<MenuItem>();
        }
    }
}
