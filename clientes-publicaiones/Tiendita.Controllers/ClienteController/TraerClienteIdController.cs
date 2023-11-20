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
    public class TraerClienteIdController: ITraerClienteIdController
    {
    
        readonly ITraerClienteIdInputPort _inputPort;
        readonly ITraerClienteIdPresenter _presenter;
        public TraerClienteIdController(ITraerClienteIdInputPort inputPort, ITraerClienteIdPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        async Task<TraerClienteWRP> ITraerClienteIdController.TraerCliente(int IdCliente)
        {
                await _inputPort.Handle(IdCliente);
                return _presenter.Cliente;
        }
        
    }
}
