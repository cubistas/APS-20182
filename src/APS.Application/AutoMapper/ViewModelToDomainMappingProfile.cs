using APS.Application.AutoMapper.ViewModelToDomain;
using AutoMapper;

namespace APS.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            UsuarioMap.Map(this);
            Common.Map(this);
        }
    }
}