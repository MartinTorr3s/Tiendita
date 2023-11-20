#nullable disable
//using Microsoft.EntityFrameworkCore.sql
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.Repository.Contexto;
using Tiendita.Repository.Repositorie;

namespace Tiendita.Repository
{
    public static class DependencyContainerss
    {

        //public static IServiceCollection AddServicesRepositories(this IServiceCollection services,
        //    IConfiguration configuration, string connectionStringName)
        //{
        //    services.AddDbContext<TienditaContexto>(options =>
        //    options.UseMySQL(configuration
        //    .GetConnectionString(connectionStringName)));

        //    services.AddScoped<IClienteRepository, ClienteRepository>();

        //    return services;
        //}
        public static IServiceCollection AddServicesRepositories(this IServiceCollection services,
            IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<TienditaContexto>(options =>
                options.UseMySQL(configuration.GetConnectionString(connectionStringName)));

            services.AddScoped<IClienteRepository, ClienteRepository>();
            

            return services;
        }
    }
}
