﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Infra.CrossCutting.Bus
{
    public sealed class InMemory
    {
        public static Func<IServiceProvider> ContainerFunc { get; set; }
        private static IServiceProvider Container => ContainerFunc?.Invoke();
        
        public static TService GetService<TService>()
        {
            return (TService)Container.GetService(typeof(TService));
        }
    }
}
