using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.Presenters.Presenters.ClientePresenters
{
    public class BorrarClientePresenter : IBorrarClientePresenter
    {
        public BorrarClienteWRP Cliente { get; private set; } = new BorrarClienteWRP();
        public Task Handle(BorrarClienteWRP cliente)
        {
            Cliente.NumeroError = cliente.NumeroError;
            Cliente.MensajeError = cliente.MensajeError;
            Cliente.IdCliente = cliente.IdCliente;
            return Task.CompletedTask;
        }
    }
}
