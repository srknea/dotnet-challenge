using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SiparisYonetimAPI.Application.Repositories;
//using SiparisYonetimAPI.Application.Abstractions;
//using SiparisYonetimAPI.Persistence.Concretes;
using SiparisYonetimAPI.Persistence.Contexts;
using SiparisYonetimAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddSingleton<IProductService, ProductService>();
            services.AddDbContext<SiparisYonetimAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<IFirmReadRepository, FirmReadRepository>();
            services.AddScoped<IFirmWriteRepository, FirmWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

        }
    }
}
