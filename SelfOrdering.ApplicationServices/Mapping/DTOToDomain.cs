using AutoMapper;

namespace SelfOrdering.ApplicationServices.Mapping
{
    public class DTOToDomain : Profile
    {
        public DTOToDomain()
        {
            //Mapper.CreateMap<RestaurantDTO, Domain.Restaurant.Restaurant>()
            //    .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
            //    .ForMember(dest => dest.Menu, src => src.MapFrom(x => x.Menu))
            //    .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
            //    .ForMember(dest => dest.TotalNumberOfTables, src => src.MapFrom(x => x.TotalNumberOfTables))
            //    .ForMember(dest => dest.Address, src => src.MapFrom(x => x.Address));

            //Mapper.CreateMap<MenuDTO, Domain.Restaurant.Menu>()
            //    .ForMember(dest => dest.MenuSections, src => src.MapFrom(x => x.MenuSections))
            //    .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name));

            //Mapper.CreateMap<MenuSectionDTO, Domain.Restaurant.MenuSection>()
            //    .ForMember(dest => dest.Items, src => src.MapFrom(x => x.Items))
            //    .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
            //    .ForMember(dest => dest.SubSections, src => src.MapFrom(x => x.SubSections));

            //Mapper.CreateMap<MenuItemDTO, Domain.Restaurant.MenuItem>()
            //    .ForMember(dest => dest.Description, src => src.MapFrom(x => x.Description))
            //    .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
            //    .ForMember(dest => dest.LargePicture, src => src.MapFrom(x => x.LargePicture))
            //    .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
            //    .ForMember(dest => dest.Price, src => src.MapFrom(x => x.Price))
            //    .ForMember(dest => dest.ShortDescription, src => src.MapFrom(x => x.ShortDescription))
            //    .ForMember(dest => dest.SmallPicture, src => src.MapFrom(x => x.SmallPicture))
            //    .ForMember(dest => dest.Suggestions, src => src.MapFrom(x => x.Suggestions));
            
            //Mapper.CreateMap<AddressDTO, Domain.Restaurant.Address>()
            //    .ForMember(dest => dest.Country, src => src.MapFrom(x => x.Country))
            //    .ForMember(dest => dest.Latitude, src => src.MapFrom(x => x.Latitude))
            //    .ForMember(dest => dest.Longitude, src => src.MapFrom(x => x.Longitude))
            //    .ForMember(dest => dest.State, src => src.MapFrom(x => x.State))
            //    .ForMember(dest => dest.StreetName, src => src.MapFrom(x => x.StreetName))
            //    .ForMember(dest => dest.StreetNumber, src => src.MapFrom(x => x.StreetNumber))
            //    .ForMember(dest => dest.Suburb, src => src.MapFrom(x => x.Suburb))
            //    .ForMember(dest => dest.ZipCode, src => src.MapFrom(x => x.ZipCode));
            
            Mapper.AssertConfigurationIsValid();
        }
        
    }
}
