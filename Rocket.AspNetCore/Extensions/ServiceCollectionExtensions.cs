using Microsoft.Extensions.DependencyInjection;
using Rocket.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rocket.AspNetCore.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterType(this IServiceCollection services,List<Type> typeList, ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            if (typeList.Count()==0)
            {
                return services;
            }

            Dictionary<Type, Type[]> dictionAry = new Dictionary<Type, Type[]>();
            foreach (var type in typeList)
            {
                Type[] interfaces = type.GetInterfaces();
                dictionAry.Add(type,interfaces);
            }

            if (dictionAry.Keys.Count()>0)
            {
                foreach (var key in dictionAry.Keys)
                {
                    foreach (var serviceType in dictionAry[key])
                    {
                        switch (serviceLifetime)
                        {
                            case ServiceLifetime.Singleton:
                                services.AddSingleton(serviceType,key);
                                break;
                            case ServiceLifetime.Scoped:
                                services.AddScoped(serviceType,key);
                                break;
                            case ServiceLifetime.Transient:
                                services.AddTransient(serviceType, key);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            return services;
        }

        public static IServiceCollection RegistryAllType(IRocketBuilder rocketBuilder,string load = "")
        {
            //rocketBuilder.Services.RegisterType();
        }

        private static bool Match(string load ="",string matchAssemblies)
        {
            var assemblyName = Path.GetFileName(load);
            if (assemblyName.StartsWith($"{AppDomain.CurrentDomain.FriendlyName}.Views"))
                return false;
            if (assemblyName.StartsWith($"{AppDomain.CurrentDomain.FriendlyName}.PrecompiledViews"))
                return false;
            return Regex.IsMatch(assemblyName, matchAssemblies, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        } 
    }
}
