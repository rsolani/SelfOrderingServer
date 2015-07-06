using AutoMapper;

namespace SelfOrdering.Api.Mapping
{
    public class ViewModelToDTO : Profile
    {
        public ViewModelToDTO()
        {

            Mapper.AssertConfigurationIsValid();
        }
        
    }
}
