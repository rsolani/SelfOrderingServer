using System.Collections.Generic;

namespace SelfOrdering.Api.Models.Restaurant
{
    public class MenuViewModel
    {
        public string Name { get; set; }
        public IReadOnlyList<MenuSectionViewModel> MenuSections { get; set; }

        public MenuViewModel()
        {
            MenuSections = new List<MenuSectionViewModel>();
        }
    }
}
