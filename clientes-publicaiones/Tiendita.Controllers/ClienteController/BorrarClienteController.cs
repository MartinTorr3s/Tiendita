using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.Controllers.ClienteController
{
    public class BorrarClienteController : IBorrarClienteController
    {
        readonly IBorrarClienteInputPort _inputPort;
        readonly IBorrarClientePresenter _presenter;
        public BorrarClienteController(IBorrarClienteInputPort inputPort, IBorrarClientePresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }
        public async Task<BorrarClienteWRP> BorrarCliente(int IdCliente)
        {
            await _inputPort.Handle(IdCliente);
            return _presenter.Cliente;

        }

    }
}

