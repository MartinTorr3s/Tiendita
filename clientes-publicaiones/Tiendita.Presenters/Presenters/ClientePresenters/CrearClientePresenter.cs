using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.Presenters.Presenters.ClientePresenters
{
    public class CrearClientePresenter : ICrearClientePresenter
    {
        public CrearBorrarClienteWRP Cliente { get; private set; } = new CrearBorrarClienteWRP();

        public Task Handle(CrearBorrarClienteWRP cliente)
        {

            cliente.NumeroError = cliente.NumeroError;
            cliente.ValidationErrors = cliente.ValidationErrors;
            cliente.MensajeError = cliente.MensajeError;
            cliente.IdCliente = cliente.IdCliente;
            return Task.CompletedTask;
        }
    }
}
