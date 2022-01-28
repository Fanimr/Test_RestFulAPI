using API.Data.Implementation;
using API.Domain.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace API.CrossDependency.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProductRepository, ProductImplementation>();
        }
    }
}
