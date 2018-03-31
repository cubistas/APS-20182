using APS.Application.AutoMapper.ViewModelToDomain;
using AutoMapper;

namespace APS.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {
            
        }
    }
}