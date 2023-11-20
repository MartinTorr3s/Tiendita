using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;

namespace Tiendita.WebApi.EndPoint.Cliente
{
    public static class TienditaTraerTodosClientesEndPoint
    {
        public static WebApplication TraerTodosClientesEndPoint(this WebApplication app)
        {
            app.MapGet("/Todos/Clientes", async (ITraerTodosClientesController controller) =>
            {
                var clientes = await controller.TraerTodosClientes();

                if (clientes == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
                else if (clientes.NumeroError != 0 && !string.IsNullOrEmpty(clientes.MensajeError))
                {
                    return Results.BadRequest(clientes);
                }
                {
                    return Results.Ok(clientes);
                }
            });

            return app;
        }
    }
}
