using System.Collections.Generic;

namespace SelfOrdering.ApplicationServices.DTO
{
    public class MenuDTO
    {
        public string Name { get; set; }
        public IReadOnlyList<MenuSectionDTO> MenuSections { get; set; }

        public MenuDTO()
        {
            MenuSections = new List<MenuSectionDTO>();
        }
    }
}
