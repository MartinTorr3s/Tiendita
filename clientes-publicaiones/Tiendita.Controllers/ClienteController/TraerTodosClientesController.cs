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
    public class TraerTodosClientesController : ITraerTodosClientesController
    {
        readonly ITraerTodosClientesInputPort _inputPort;
        readonly ITraerTodosClientesPresenter _presenter;

        public TraerTodosClientesController(ITraerTodosClientesInputPort inputPort, ITraerTodosClientesPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<TraerTodosClientesWRP> TraerTodosClientes()
        {
            await _inputPort.Handle();
            return _presenter.Clientes;
        }
    }
}
