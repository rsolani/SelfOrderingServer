using System.Collections.Generic;

namespace SelfOrdering.Api.Models.Restaurant
{
    public class RestaurantListViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public AddressViewModel Address { get; set; }

        public RestaurantListViewModel()
        {
        }
    }
    
}
