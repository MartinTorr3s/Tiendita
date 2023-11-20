using Microsoft.Extensions.DependencyInjection;
using Tiendita.Presenters.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.OuputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;

namespace Tiendita.Presenters
{
    public static class ContenedorDependencia
    {
        public static IServiceCollection AddServicesPresenter(this IServiceCollection services)
        {
            services.AddScoped<TraerTodosClientesPresenter>();

            services.AddScoped<ITraerTodosClientesOuputPort, TraerTodosClientesPresenter>();

            services.AddScoped<ITraerTodosClientesPresenter, TraerTodosClientesPresenter>();


            services.AddScoped<ICrearClientePresenter, CrearClientePresenter>();

            services.AddScoped<ITraerClienteIdPresenter, TraerClienteIdPresenter>();

            services.AddScoped<IBorrarClientePresenter, BorrarClientePresenter>();

            services.AddScoped<IActualizarClientePresenter, ActualizarClientePresenter>();

            services.AddScoped<ICargarDomicilioPresenter, CargarDomicilioPresenter>();

            
            return services;
        }
    }
}
