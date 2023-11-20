using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;

namespace Tiendita.WebApi.EndPoint.Cliente

{
    public static class CrearClienteEndPoint
    {
        public static WebApplication CreateClienteEndPoint(this WebApplication app)
        {
            app.MapPost("/Crear/Cliente", async (CrearClienteDTO request, ICrearClienteController controller) =>
            {
                var result = await controller.CrearCliente(request);

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
        }
    }
}
