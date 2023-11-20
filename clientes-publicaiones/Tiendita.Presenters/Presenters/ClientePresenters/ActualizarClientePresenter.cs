using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.Presenters.Presenters.ClientePresenters
{
    public class ActualizarClientePresenter : IActualizarClientePresenter
    {
        public ActualizarClienteWRP Cliente { get; private set; } = new ActualizarClienteWRP();

        public Task Handle(ActualizarClienteWRP cliente)
        {
            Cliente.NumeroError = cliente.NumeroError;
            Cliente.ValidationErrors = cliente.ValidationErrors;
            Cliente.MensajeError = cliente.MensajeError;
            //Cliente.IdCliente = cliente.IdCliente;
            Cliente.TelefonoCliente = cliente.TelefonoCliente;
            Cliente.CalleCliente = cliente.CalleCliente;
            Cliente.NumCalleCliente = cliente.NumCalleCliente;
            Cliente.NumDepartamentoCliente = cliente.NumCalleCliente;
            Cliente.InformacionAdicionalCliente = cliente.InformacionAdicionalCliente;
            return Task.CompletedTask;
        }
    }
}
