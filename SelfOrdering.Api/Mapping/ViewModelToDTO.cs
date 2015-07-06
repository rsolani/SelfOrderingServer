using AutoMapper;
using SelfOrdering.Api.Models;
using SelfOrdering.ApplicationServices.DTO;

namespace SelfOrdering.Api.Mapping
{
    public class ViewModelToDTO : Profile
    {
        public ViewModelToDTO()
        {
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
