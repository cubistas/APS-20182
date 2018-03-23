using APS.Application.AppService;
using APS.Application.Interfaces;
using SimpleInjector;

namespace APS.Infra.CrossCutting.Ioc.Modules
{
    public static class AplicationServiceModules
    {
        public static void Register(Container container)
        {
            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);
        }
    }
}
