using System.Collections.Generic;

namespace SelfOrdering.ApplicationServices.DTO
{
   
    public class MenuSectionDTO
    {
        public string Name { get; set; }
        public IList<MenuItemDTO> Items {get; set; }
        public IList<MenuSectionDTO> SubSections { get; set; }

        public MenuSectionDTO()
        {
            SubSections = new List<MenuSectionDTO>();
        }
    }

}
