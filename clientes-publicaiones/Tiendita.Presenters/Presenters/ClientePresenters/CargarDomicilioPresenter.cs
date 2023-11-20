using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.Presenters.Presenters.ClientePresenters
{
    public class CargarDomicilioPresenter : ICargarDomicilioPresenter
    {
        public CargarDomicilioWRP Cliente { get; private set; } = new CargarDomicilioWRP();

        public Task Handle(CargarDomicilioWRP cliente)
        {
            Cliente.NumeroError = cliente.NumeroError;
            Cliente.ValidationErrors = cliente.ValidationErrors;
            Cliente.MensajeError = cliente.MensajeError;
            Cliente.TelefonoCliente = cliente.TelefonoCliente;
            Cliente.CalleCliente = cliente.CalleCliente;
            Cliente.NumCalleCliente = cliente.NumCalleCliente;
            Cliente.NumDepartamentoCliente = cliente.NumCalleCliente;
            Cliente.InformacionAdicionalCliente = cliente.InformacionAdicionalCliente;
            return Task.CompletedTask;
        }
    }
}
