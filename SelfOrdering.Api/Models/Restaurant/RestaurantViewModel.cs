using System.Collections.Generic;

namespace SelfOrdering.Api.Models.Restaurant
{
    public class RestaurantViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int TotalNumberOfTables { get; set; }

        public AddressViewModel Address { get; set; }

        public IReadOnlyList<TableViewModel> Tables { get; private set; }

        public MenuViewModel Menu { get; private set; }

        public RestaurantViewModel()
        {
            Menu = new MenuViewModel();
            Tables = new List<TableViewModel>();
        }
    }
    
}
