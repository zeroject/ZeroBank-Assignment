using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyResolver
{
    public static class DependencyResolverService
    {
        public static void RegisterInfrastructureLayer(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
