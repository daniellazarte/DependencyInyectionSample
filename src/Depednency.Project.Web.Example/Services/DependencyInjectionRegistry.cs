using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace Depednency.Project.Web.Example.Services
{
    public static class DependencyInjectionRegistry
    {
        public static IServiceCollection AddMyServices(this IServiceCollection services)
        {
            services.AddSingleton<ISingletonOperation, SingletonOperation>();
            services.AddScoped<IScopedOperation, ScopedOperation>();
            services.AddTransient<ItransientOperation, TransientOperation>();
            services.AddTransient<IMyService, MyService>();
            return services;
        }


    }
}
