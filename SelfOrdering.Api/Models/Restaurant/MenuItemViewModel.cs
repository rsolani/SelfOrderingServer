using System.Collections.Generic;

namespace SelfOrdering.Api.Models.Restaurant
{
    public class MenuItemViewModel
    {
        public string Id { get; set; }
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public IReadOnlyList<MenuItemViewModel> SubItems { get; set; }
        public IReadOnlyList<MenuItemViewModel> Suggestions { get; set; }
        public bool IsActive { get; set; }
        public bool IsRestrictedByCustomerAge { get; set; }
        
        public byte[] SmallPicture { get; set; }
        public byte[] LargePicture { get; set; }

        public MenuItemViewModel()
        {
            Suggestions = new List<MenuItemViewModel>();
        }
    }
}
