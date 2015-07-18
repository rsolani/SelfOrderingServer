using AutoMapper;
using SelfOrdering.Api.Models.Customer;
using SelfOrdering.Api.Models.MessageLog;
using SelfOrdering.ApplicationServices.Customer;
using SelfOrdering.ApplicationServices.MessageLog;

namespace SelfOrdering.Api.Mapping
{
    public class ViewModelToDTO : Profile
    {
        public ViewModelToDTO()
        {
            Mapper.CreateMap<MessageHandlerViewModel, MessageHandlerDTO>()
                .ForMember(dest => dest.Duration, src => src.MapFrom(x => x.Duration))
                .ForMember(dest => dest.HttpStatusCode, src => src.MapFrom(x => x.HttpStatusCode))
                .ForMember(dest => dest.Ip, src => src.MapFrom(x => x.Ip))
                .ForMember(dest => dest.Method, src => src.MapFrom(x => x.Method))
                .ForMember(dest => dest.Parameters, src => src.MapFrom(x => x.Parameters))
                .ForMember(dest => dest.ResponseContent, src => src.MapFrom(x => x.ResponseContent))
                .ForMember(dest => dest.RequestContent, src => src.MapFrom(x => x.RequestContent))
                .ForMember(dest => dest.Verb, src => src.MapFrom(x => x.Verb));

            Mapper.CreateMap<CustomerViewModel, CustomerDTO>()
                .ForMember(dest => dest.Age, src => src.Ignore())
                .ForMember(dest => dest.BirthDate, src => src.MapFrom(x => x.DateOfBirth))
                .ForMember(dest => dest.Cpf, src => src.MapFrom(x => x.Cpf))
                .ForMember(dest => dest.Email, src => src.MapFrom(x => x.Email))
                .ForMember(dest => dest.Id, src => src.MapFrom(x => x.Id))
                .ForMember(dest => dest.LoginProvider, src => src.MapFrom(x => x.LoginType))
                .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.UserImageUrl, src => src.MapFrom(x => x.UserImageUrl));

            Mapper.AssertConfigurationIsValid();
        }
        
    }
}
