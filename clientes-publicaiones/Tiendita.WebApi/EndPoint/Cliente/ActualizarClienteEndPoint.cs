using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;

namespace Tiendita.WebApi.EndPoint.Cliente
{
    public static class TienditaActualizarClienteEndPoint
    {
        public static WebApplication ActualizarClienteEndPoint(this WebApplication app)
        {
            app.MapPost("/Cliente/Actualizar/{id}", async (ActualizarClienteDTO request, IActualizarClienteController controller) =>
            {
                var result = await controller.ActualizarCliente(request);

                if (!string.IsNullOrEmpty(result.MensajeError) || result.ValidationErrors != null)
                {
                    return Results.BadRequest(result);
                }
                else
                {
                    return Results.Ok(result);
                }

            });
            return app;
            //app.MapPut("/cliente/actualizar/{id}", async (IActualizarClienteController controller, int id, ActualizarClienteDTO request) =>
            //{
            //    var result = await controller.ActualizarCliente(request);

            //    if (!string.IsNullOrEmpty(result.MensajeError) || result.ValidationErrors != null)
            //    {
            //        return Results.BadRequest(result);
            //    }
            //    else
            //    {
            //        return Results.Ok(result);
            //    }
            //});

            //return app;
        }

    }
}
