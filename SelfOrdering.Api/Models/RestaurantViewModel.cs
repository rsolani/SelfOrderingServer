namespace SelfOrdering.Api.Models
{
    public class RestaurantViewModel
    {
        public string Id { get; set; } 
         
        public string Name { get; set; }

        public AddressViewModel Address { get; set; }

        public int TotalNumberOfTables { get; set; }

        public MenuViewModel Menu { get; set; }

        public RestaurantViewModel()
        {
            Menu = new MenuViewModel();
        }
    }
    
}
