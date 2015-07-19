using AutoMapper;
using SelfOrdering.ApplicationServices.Customer;
using SelfOrdering.ApplicationServices.Restaurant;

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
                .ForMember(dest => dest.Address, src => src.MapFrom(x => x.Address))
                .ForMember(dest => dest.Type, src => src.MapFrom(x => x.Type))
                .ForMember(dest => dest.Tables, src => src.MapFrom(x => x.Tables));

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
                .ForMember(dest => dest.Latitude, src => src.MapFrom(x => x.Location.Coordinates.Latitude))
                .ForMember(dest => dest.Longitude, src => src.MapFrom(x => x.Location.Coordinates.Longitude))
                .ForMember(dest => dest.State, src => src.MapFrom(x => x.State))
                .ForMember(dest => dest.StreetName, src => src.MapFrom(x => x.StreetName))
                .ForMember(dest => dest.StreetNumber, src => src.MapFrom(x => x.StreetNumber))
                .ForMember(dest => dest.Suburb, src => src.MapFrom(x => x.Suburb))
                .ForMember(dest => dest.City, src => src.MapFrom(x => x.City))
                .ForMember(dest => dest.ZipCode, src => src.MapFrom(x => x.ZipCode))
                .ForMember(dest => dest.DistanceFromUser, src => src.Ignore());

            Mapper.CreateMap<Domain.Restaurant.Table, TableDTO>()
                .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
                .ForMember(dest => dest.IsOccupied, src => src.MapFrom(x => x.IsOccupied))
                .ForMember(dest => dest.Number, src => src.MapFrom(x => x.Number));


            Mapper.CreateMap<Domain.Customer.Customer, CustomerDTO>()
                .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
                .ForMember(dest => dest.LoginProvider, src => src.MapFrom(x => x.LoginProvider))
                .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
                //.ForMember(dest => dest.Orders, src => src.MapFrom(x => x.Orders))
                .ForMember(dest => dest.Age, src => src.MapFrom(x => x.Age))
                .ForMember(dest => dest.BirthDate, src => src.MapFrom(x => x.BirthDate))
                .ForMember(dest => dest.Cpf, src => src.MapFrom(x => x.Cpf))
                .ForMember(dest => dest.Email, src => src.MapFrom(x => x.Email))
                .ForMember(dest => dest.UserImageUrl, src => src.MapFrom(x => x.UserImageUrl));


            Mapper.AssertConfigurationIsValid();
        }
        
    }
}
