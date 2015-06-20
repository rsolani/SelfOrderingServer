using System.Collections.Generic;
using SelfOrdering.Domain;

namespace SelfOrdering.ApplicationServices.DTO
{
    public class MenuItemDTO : MongoEntityBase
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public IList<MenuItemDTO> Suggestions { get; set; }

        public byte[] SmallPicture { get; set; }
        public byte[] LargePicture { get; set; }

        public decimal Price { get; set; }

        public MenuItemDTO()
        {
            Suggestions = new List<MenuItemDTO>();

        }
    }

}
