using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tiendita.UseCases;
using Tiendita.Presenters;
using Tiendita.Repository;


namespace Tiendita.InyeccionDependecia
{
    public static class ContenedorDependencia
    {
        public static IServiceCollection AddTienditaServices(this IServiceCollection services, IConfiguration configuration, string connectionString)
        {

            services
                    .AddServicesRepositories(configuration, connectionString)
                    .AddServicesUsesCases()
                    .AddServicesPresenter()
                    .AddServicesControllers();
 
         
            return services;
        }
    }
}
