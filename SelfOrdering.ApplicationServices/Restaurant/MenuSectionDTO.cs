using System.Collections.Generic;

namespace SelfOrdering.ApplicationServices.Restaurant
{
   
    public class MenuSectionDTO
    {
        public string Name { get; set; }
        public IReadOnlyList<MenuItemDTO> Items {get; set; }
        public IReadOnlyList<MenuSectionDTO> SubSections { get; set; }

        public MenuSectionDTO()
        {
            SubSections = new List<MenuSectionDTO>();
        }
    }
}
