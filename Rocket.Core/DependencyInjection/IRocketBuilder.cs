using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket.Core.DependencyInjection
{
    /// <summary>
    /// 注入方式改成两种
    /// </summary>
    public interface IRocketBuilder
    {
        IServiceCollection Services { get; }

        IConfiguration Configuration { get; }
    }
}
