using Autofac;
using Puc.Clean.Livraria.Infrastructure.DataAccess;
using Puc.Clean.Livraria.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Infrastructure.Modules
{
    public class InfrastructureModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookStoreContext>()
                .As<BookStoreContext>()
                .SingleInstance();

            builder.RegisterAssemblyTypes(typeof(OutputConverter).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
