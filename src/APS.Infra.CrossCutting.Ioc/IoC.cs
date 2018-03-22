

using APS.Application.AppService;
using APS.Application.Interfaces;
using SimpleInjector;
using System;
using System.Reflection;

namespace APS.Infra.CrossCutting.IoC
{
    public static class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        {
            var container = new Container();            
            
            MarpearRegistgros(container);

            container.Verify();
            

            return container;
        }

        private static void MarpearRegistgros(Container container)
        {
            container.Register<IUsuarioAppService, UsuarioAppService>();
        }
    }
}
