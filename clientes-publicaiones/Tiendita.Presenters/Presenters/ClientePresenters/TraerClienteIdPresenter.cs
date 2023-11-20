using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.Presenters.Presenters.ClientePresenters
{
    public class TraerClienteIdPresenter : ITraerClienteIdPresenter
    {
        public TraerClienteWRP Cliente { get; private set; }

        public Task Handle(TraerClienteWRP cliente)
        {
            Cliente = new TraerClienteWRP
            {
                IdCliente = cliente.IdCliente,
                NombreCliente = cliente.NombreCliente,
                ApellidoCliente= cliente.ApellidoCliente,
                CorreoCliente= cliente.CorreoCliente,
                DniCliente= cliente.DniCliente,
                NumeroError = cliente.NumeroError,
                MensajeError = cliente.MensajeError
            };
            return Task.CompletedTask;
        }
    }
}
