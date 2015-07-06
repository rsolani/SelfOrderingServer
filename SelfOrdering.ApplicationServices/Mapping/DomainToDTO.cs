using AutoMapper;
using SelfOrdering.ApplicationServices.DTO;

namespace SelfOrdering.ApplicationServices.Mapping
{
    public class DomainToDTO : Profile
    {
        public DomainToDTO()
        {
            Mapper.CreateMap<Domain.Restaurant.Restaurant, RestaurantDTO>()
                .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
                .ForMember(dest => dest.Menu, src => src.MapFrom(x => x.Menu))
                .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.TotalNumberOfTables, src => src.MapFrom(x => x.TotalNumberOfTables))
                .ForMember(dest => dest.Address, src => src.MapFrom(x => x.Address));

            Mapper.CreateMap<Domain.Restaurant.Menu, MenuDTO>()
                .ForMember(dest => dest.MenuSections, src => src.MapFrom(x => x.MenuSections))
                .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name));

            Mapper.CreateMap<Domain.Restaurant.MenuSection, MenuSectionDTO>()
                .ForMember(dest => dest.Items, src => src.MapFrom(x => x.Items))
                .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.SubSections, src => src.MapFrom(x => x.SubSections));

            Mapper.CreateMap<Domain.Restaurant.MenuItem, MenuItemDTO>()
                .ForMember(dest => dest.Description, src => src.MapFrom(x => x.Description))
                .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
                .ForMember(dest => dest.LargePicture, src => src.MapFrom(x => x.LargePicture))
                .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.Price, src => src.MapFrom(x => x.Price))
                .ForMember(dest => dest.ShortDescription, src => src.MapFrom(x => x.ShortDescription))
                .ForMember(dest => dest.SmallPicture, src => src.MapFrom(x => x.SmallPicture))
                .ForMember(dest => dest.Suggestions, src => src.MapFrom(x => x.Suggestions))
                .ForMember(dest => dest.IsActive, src => src.MapFrom(x => x.IsActive))
                .ForMember(dest => dest.IsRestrictedByCustomerAge, src => src.MapFrom(x => x.IsRestrictedByCustomerAge));
            
            Mapper.CreateMap<Domain.Restaurant.Address, AddressDTO>()
                .ForMember(dest => dest.Country, src => src.MapFrom(x => x.Country))
                .ForMember(dest => dest.Latitude, src => src.MapFrom(x => x.Latitude))
                .ForMember(dest => dest.Longitude, src => src.MapFrom(x => x.Longitude))
                .ForMember(dest => dest.State, src => src.MapFrom(x => x.State))
                .ForMember(dest => dest.StreetName, src => src.MapFrom(x => x.StreetName))
                .ForMember(dest => dest.StreetNumber, src => src.MapFrom(x => x.StreetNumber))
                .ForMember(dest => dest.Suburb, src => src.MapFrom(x => x.Suburb))
                .ForMember(dest => dest.ZipCode, src => src.MapFrom(x => x.ZipCode));
            
            Mapper.AssertConfigurationIsValid();
        }
        
    }
}
