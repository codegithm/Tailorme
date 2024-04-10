using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TailorMe.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection ConfigureApplicationSetting(this IServiceCollection service)
        {
            service.AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });
            service.AddAutoMapper(Assembly.GetExecutingAssembly());

            return service;
        }
    }
}
