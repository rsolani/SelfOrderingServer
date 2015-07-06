using AutoMapper;
using SelfOrdering.Api.Models;
using SelfOrdering.ApplicationServices.DTO;

namespace SelfOrdering.Api.Mapping
{
    public class DTOToViewModel : Profile
    {
        public DTOToViewModel()
        {
            Mapper.CreateMap<RestaurantDTO, RestaurantViewModel>()
                .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
                .ForMember(dest => dest.Menu, src => src.MapFrom(x => x.Menu))
                .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.TotalNumberOfTables, src => src.MapFrom(x => x.TotalNumberOfTables))
                .ForMember(dest => dest.Address, src => src.MapFrom(x => x.Address))
                .ForMember(dest => dest.Tables, src => src.MapFrom(x => x.Tables));

            Mapper.CreateMap<MenuDTO, MenuViewModel>()
                .ForMember(dest => dest.MenuSections, src => src.MapFrom(x => x.MenuSections))
                .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name));

            Mapper.CreateMap<MenuSectionDTO, MenuSectionViewModel>()
                .ForMember(dest => dest.Items, src => src.MapFrom(x => x.Items))
                .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.SubSections, src => src.MapFrom(x => x.SubSections));

            Mapper.CreateMap<MenuItemDTO, MenuItemViewModel>()
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

            Mapper.CreateMap<AddressDTO, AddressViewModel>()
                .ForMember(dest => dest.Country, src => src.MapFrom(x => x.Country))
                .ForMember(dest => dest.Latitude, src => src.MapFrom(x => x.Latitude))
                .ForMember(dest => dest.Longitude, src => src.MapFrom(x => x.Longitude))
                .ForMember(dest => dest.State, src => src.MapFrom(x => x.State))
                .ForMember(dest => dest.StreetName, src => src.MapFrom(x => x.StreetName))
                .ForMember(dest => dest.StreetNumber, src => src.MapFrom(x => x.StreetNumber))
                .ForMember(dest => dest.Suburb, src => src.MapFrom(x => x.Suburb))
                .ForMember(dest => dest.ZipCode, src => src.MapFrom(x => x.ZipCode))
                .ForMember(dest => dest.DistanceFromUser, src => src.MapFrom(x => x.DistanceFromUser))
                ;

            Mapper.CreateMap<TableDTO, TableViewModel>()
                .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
                .ForMember(dest => dest.IsOccupied, src => src.MapFrom(x => x.IsOccupied))
                .ForMember(dest => dest.Number, src => src.MapFrom(x => x.Number));

            Mapper.CreateMap<CustomerDTO, CustomerViewModel>()
                .ForMember(dest => dest.Age, src => src.Ignore())
                .ForMember(dest => dest.DateOfBirth, src => src.MapFrom(x => x.BirthDate))
                .ForMember(dest => dest.Cpf, src => src.MapFrom(x => x.Cpf))
                .ForMember(dest => dest.Email, src => src.MapFrom(x => x.Email))
                .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
                .ForMember(dest => dest.LoginType, src => src.MapFrom(x => x.LoginProvider))
                .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.UserImageUrl, src => src.MapFrom(x => x.UserImageUrl)); ;


            Mapper.AssertConfigurationIsValid();
        }
    }
}
