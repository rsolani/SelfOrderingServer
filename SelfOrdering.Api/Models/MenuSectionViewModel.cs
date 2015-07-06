using System.Collections.Generic;

namespace SelfOrdering.Api.Models
{
   
    public class MenuSectionViewModel
    {
        public string Name { get; set; }
        public IReadOnlyList<MenuItemViewModel> Items {get; set; }
        public IReadOnlyList<MenuSectionViewModel> SubSections { get; set; }

        public MenuSectionViewModel()
        {
            SubSections = new List<MenuSectionViewModel>();
            Items = new List<MenuItemViewModel>();
        }
    }
}
