

using APS.Application.AppService;
using APS.Application.Interfaces;
using APS.Infra.CrossCutting.Bus;
using APS.Infra.CrossCutting.Ioc;
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


        private static readonly Container Container = new Container();

        public static Container RegisterServices()
        {
            Container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            MapperModules(Container);

            Container.Verify();

            Container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            //(paratro) HttpConfiguration configuration
            // pacote using SimpleInjector.Integration.WebApi;
            //Lifestyle.CreateHybrid
            //container.RegisterWebApiControllers(configuration);

            InMemory.ContainerAccessor = () => Container;

            return Container;
        }

        private static void MapperModules(Container container)
        {
            AplicationServiceModules.Register(container);
            ServiceModules.Register(container);
            RepositoryModules.Register(container);
        }
    }
}
