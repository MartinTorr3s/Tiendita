using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.Controllers.ClienteController
{
    public class CrearClienteController : ICrearClienteController
    {
        readonly ICrearClienteInputPort _inputPort;
        readonly ICrearClientePresenter _presenter;

        public CrearClienteController(ICrearClienteInputPort inputPort, ICrearClientePresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }
        public async Task<CrearBorrarClienteWRP> CrearCliente(CrearClienteDTO request)
        {
            await _inputPort.Handle(request);
            return _presenter.Cliente;
        }
    }
}



