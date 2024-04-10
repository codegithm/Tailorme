using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TailorMe.Application.Persistence.Contrants;
using TailorMe.Persistence.Persistence;
using TailorMe.Persistence.Repositories;

namespace TailorMe.Persistence
{
    public static class DendencyInjection
    {
        public static IServiceCollection ConfiguringPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("TailorMeConnectionString")
                    ));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ITopMeasurementRepository, TopMeasurementRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IBottomMeasurementRepository, BottomMeasurementRepository>();

            return services;            
        }
    }
}
