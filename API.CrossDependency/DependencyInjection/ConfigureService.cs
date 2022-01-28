using API.Domain.Interfaces.Services.Product;
using API.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace API.CrossDependency.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProductService, ProductService>();
        }
    }
}
