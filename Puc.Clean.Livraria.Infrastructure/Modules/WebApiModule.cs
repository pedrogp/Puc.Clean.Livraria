using Autofac;
using Puc.Clean.Livraria.Application;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Puc.Clean.Livraria.Infrastructure.Modules
{
    public class WebApiModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetEntryAssembly())
                .AsClosedTypesOf(typeof(IOutputBoundary<>))
                .InstancePerLifetimeScope();
        }
    }
}
