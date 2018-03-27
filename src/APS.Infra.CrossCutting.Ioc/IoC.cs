

using APS.Application.AppService;
using APS.Application.Interfaces;
using APS.Infra.CrossCutting.Ioc.Modules;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Reflection;

namespace APS.Infra.CrossCutting.IoC
{
    public static class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            MapperModules(container);

            container.Verify();

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());            

            return container;
        }

        private static void MapperModules(Container container)
        {
            AplicationServiceModules.Register(container);
            ServiceModules.Register(container);
            RepositoryModules.Register(container);
        }
    }
}
