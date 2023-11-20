using Tiendita.InyeccionDependecia;
using Tiendita.WebApi.EndPoint.Cliente;

namespace Tiendita.WebApi
{
    public static class WebApplicationHelper
    {
        public static WebApplication CreateWebApplication(this WebApplicationBuilder builder)
        {
            // Configurar APIExplorer para descubrir y exponer
            // los metadatos de los endpoints de la aplicación.
            builder.Services.AddEndpointsApiExplorer();

            // Agregar el generador que construye los objetos de
            // documentación de Swagger con la funcionalidad del APIExplorer.
            builder.Services.AddSwaggerGen();

            // Registrar los servicios de la aplicación
            builder.Services.AddTienditaServices(
                builder.Configuration, "Connection1");

            // Agregar el servicio CORS para clientes que se ejecutan
            // en el navegador Web (como Blazor WebAssembly).
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(config =>
                {
                    config.AllowAnyMethod();
                    config.AllowAnyHeader();
                    config.AllowAnyOrigin();    
                });
            });
            //try
            //{
            //    return builder.Build();
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //    return default;
            //}
            try
            {
                return builder.Build();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw; // Lanzar la excepción original para que puedas identificar y corregir el problema.
            }



        }
        public static WebApplication ConfigureWebApplication(
            this WebApplication app)
        {
            // Habilitar el middleware para servir el documento
            // JSON generado y la interfaz UI de Swagger en el
            // ambiente de desarrollo.
            if (app.Environment.IsDevelopment())
            {   
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Registrar los endpoints de la aplicación
            app.CreateClienteEndPoint();
            app.CargarDomicilioEndPoint();
            app.TraerTodosClientesEndPoint();
            app.TraerCliente();
            app.BorrarClienteEndPoint();
            app.ActualizarClienteEndPoint();
  

            // Agregar el Middleware CORS
            app.UseCors();

            return app;
        }
    
    }
}
