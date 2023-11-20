using Microsoft.Extensions.DependencyInjection;
using Tienda.CasoUsos.CasosUsos.ClienteCasoUso;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using static Tienda.CasoUsos.CasosUsos.ClienteCasoUso.BorrarClienteIteractor;

namespace Tiendita.UseCases
{
    public static class ContenedorDependencia
    {
        public static IServiceCollection AddServicesUsesCases(this IServiceCollection services)
        {
            services.AddScoped<ICrearClienteInputPort, CrearClienteIteractor>();
           
            services.AddScoped<ITraerClienteIdInputPort, TraerClienteIdInteractor>();

            services.AddScoped<IBorrarClienteInputPort, BorrarClienteIteractor>();

            services.AddScoped<IActualizarClienteInputPor, ActualizarClienteIteractor>();

            services.AddScoped<ICargarDomicilioClienteInputPort, CargarDomicilioIteractor>();

            
            services.AddScoped<ITraerTodosClientesInputPort, TraerTodosClientesIteractor>();
            return services;

        }
    }
}

