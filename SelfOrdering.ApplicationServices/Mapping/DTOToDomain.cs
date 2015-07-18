using AutoMapper;
using MongoDB.Bson;
using SelfOrdering.ApplicationServices.Customer;
using SelfOrdering.ApplicationServices.MessageLog;

namespace SelfOrdering.ApplicationServices.Mapping
{
    public class DTOToDomain : Profile
    {
        public DTOToDomain()
        {
            Mapper.CreateMap<MessageHandlerDTO, Domain.MessageLog.MessageHandler>()
                .ForMember(dest => dest.Id, src => src.Ignore())
                .ForMember(dest => dest.Duration, src => src.MapFrom(x => x.Duration))
                .ForMember(dest => dest.HttpStatusCode, src => src.MapFrom(x => x.HttpStatusCode))
                .ForMember(dest => dest.Ip, src => src.MapFrom(x => x.Ip))
                .ForMember(dest => dest.Method, src => src.MapFrom(x => x.Method))
                .ForMember(dest => dest.Parameters, src => src.MapFrom(x => x.Parameters))
                .ForMember(dest => dest.ResponseContent, src => src.MapFrom(x => x.ResponseContent))
                .ForMember(dest => dest.RequestContent, src => src.MapFrom(x => x.RequestContent))
                .ForMember(dest => dest.Verb, src => src.MapFrom(x => x.Verb));

            Mapper.CreateMap<CustomerDTO, Domain.Customer.Customer>()
                .ForMember(dest => dest.Id, src => src.MapFrom(x => (string.IsNullOrWhiteSpace(x.Id)) ? ObjectId.GenerateNewId() : new ObjectId(x.Id)))
                .ForMember(dest => dest.LoginProvider, src => src.MapFrom(x => x.LoginProvider))
                .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
                //.ForMember(dest => dest.Orders, src => src.MapFrom(x => x.Orders))
                .ForMember(dest => dest.Age, src => src.MapFrom(x => x.Age))
                .ForMember(dest => dest.BirthDate, src => src.MapFrom(x => x.BirthDate))
                .ForMember(dest => dest.Cpf, src => src.MapFrom(x => x.Cpf))
                .ForMember(dest => dest.Email, src => src.MapFrom(x => x.Email))
                .ForMember(dest => dest.UserImageUrl, src => src.MapFrom(x => x.UserImageUrl));            

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
