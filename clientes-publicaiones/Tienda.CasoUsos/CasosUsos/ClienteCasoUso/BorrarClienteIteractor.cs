using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.PersonalException;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tienda.CasoUsos.CasosUsos.ClienteCasoUso
{
    public class BorrarClienteIteractor : IBorrarClienteInputPort
    {
        private readonly IClienteRepository _repository;
        private readonly IBorrarClientePresenter _presenter;

        public BorrarClienteIteractor(IClienteRepository repository, IBorrarClientePresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(int IdCliente)
        {

            BorrarClienteWRP clienteResponse = new();
            try
            {
                await _repository.Borrar(IdCliente);
                await _repository.GuardarCambios();
                clienteResponse.IdCliente = IdCliente;
            }
            catch (DBMySqlException ex)
            {
                // Manejar errores
                clienteResponse.NumeroError = ex.Number;
                clienteResponse.MensajeError = ex.MessageError;
            }
            finally
            {
                // Notificar al presentador que se eliminó el Cliente.
                await _presenter.Handle(clienteResponse);
            }

        }



    }
}
