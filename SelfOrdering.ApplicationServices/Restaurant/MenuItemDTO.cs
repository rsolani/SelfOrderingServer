using System.Collections.Generic;

namespace SelfOrdering.ApplicationServices.Restaurant
{
    public class MenuItemDTO
    {
        public string Id { get; set; }
        
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public IReadOnlyList<MenuItemDTO> SubItems { get; set; }
        public IReadOnlyList<MenuItemDTO> Suggestions { get; set; }
        
        public byte[] SmallPicture { get; set; }
        public byte[] LargePicture { get; set; }

        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsRestrictedByCustomerAge { get; set; }

        public MenuItemDTO()
        {
            Suggestions = new List<MenuItemDTO>();
        }
    }
}
