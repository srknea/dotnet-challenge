using Microsoft.Extensions.DependencyInjection;
using SiparisYonetimAPI.Application.Abstractions;
using SiparisYonetimAPI.Persistence.Concretes;
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
            services.AddSingleton<IProductService, ProductService>();

        }
    }
}
