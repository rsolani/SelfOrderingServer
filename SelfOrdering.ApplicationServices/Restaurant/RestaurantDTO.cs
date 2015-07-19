using System.Collections.Generic;

namespace SelfOrdering.ApplicationServices.Restaurant
{
    public class RestaurantDTO
    {
        public string Id { get; set; } 
         
        public string Name { get; set; }
        public string Type { get; set; }

        public AddressDTO Address { get; set; }

        public int TotalNumberOfTables { get; set; }

        public IReadOnlyList<TableDTO> Tables { get; set; }

        public MenuDTO Menu { get; set; }

        public RestaurantDTO()
        {
            Menu = new MenuDTO();
        }
    }
    
}
