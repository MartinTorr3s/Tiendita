using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;

namespace Tiendita.WebApi.EndPoint.Cliente
{
    public static class TienditaBorrarClienteEndPoint
    {
        public static WebApplication BorrarClienteEndPoint(this WebApplication app)
        {
            app.MapDelete("/Cliente/Borrar/{id}", async (IBorrarClienteController  controller, int id) =>
            {
                var cliente = await controller.BorrarCliente(id);
                if (cliente == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);

                }
                else if (cliente.NumeroError != 0 && !string.IsNullOrEmpty(cliente.MensajeError))
                {
                    return Results.BadRequest(cliente);
                }

                return Results.Ok(cliente);
            });
            return app;
        }
    }
}
