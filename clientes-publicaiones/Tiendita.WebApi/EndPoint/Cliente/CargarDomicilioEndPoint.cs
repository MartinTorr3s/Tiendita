using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;

namespace Tiendita.WebApi.EndPoint.Cliente
{
    public static class TienditaCargarDomicilioEndPoint
    {
        public static WebApplication CargarDomicilioEndPoint(this WebApplication app)
        {
            app.MapPost("/Cliente/Cargar/Domicilio", async (CargarDomicilioDTO request, ICargarDomicilioController controller) =>
            {
                var result = await controller.CargarDomicilo(request);

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
