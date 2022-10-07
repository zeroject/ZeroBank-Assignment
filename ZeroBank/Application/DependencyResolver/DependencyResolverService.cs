using Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DependencyResolver
{
    public static class DependencyResolverService
    {
        public static void RegisterApplicationLayer(IServiceCollection service)
        {
            service.AddScoped<IProductService, ProductService>();
        }
    }
}
