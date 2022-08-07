using Autofac;
using Rocket.Core.AutofacDependency;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket.AspNetCore.DI
{
    public class RocketModule:InjectionModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}
