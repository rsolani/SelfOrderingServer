namespace SelfOrdering.ApplicationServices.DTO
{
    public class RestaurantDTO
    {
        public string Name { get; set; }

        public int NumberOfTables { get; set; }

        public MenuDTO Menu { get; set; }

        public RestaurantDTO()
        {
            Menu = new MenuDTO();
        }
    }
    
}
