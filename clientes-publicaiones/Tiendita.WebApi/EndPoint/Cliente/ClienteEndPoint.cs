using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;


namespace Tiendita.WebApi.EndPoint.Cliente
{
    public static class ClienteEndPoint
    {
        public static WebApplication TraerCliente(this WebApplication app)
        {
            app.MapGet("/Cliente/{id}", async (ITraerClienteIdController controller, int id) =>
            {
                var cliente = await controller.TraerCliente(id);

                if (cliente == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);

                }
                else if (cliente.NumeroError != 0 && !string.IsNullOrEmpty(cliente.MensajeError))
                {
                    return Results.BadRequest(cliente);

                }
                {
                    return Results.Ok(cliente);
                }
            });

            return app;
        }
    }
}
