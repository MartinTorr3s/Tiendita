using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tienda.CasoUsos.CasosUsos.ClienteCasoUso
{

    public class TraerClienteIdInteractor : ITraerClienteIdInputPort
    {
        private readonly IClienteRepository _repository;
        private readonly ITraerClienteIdPresenter _presenter;

        public TraerClienteIdInteractor(IClienteRepository repository, ITraerClienteIdPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }
        public async Task Handle(int IdCliente)
        {
            TraerClienteWRP clienteResponse = new();

            try
            {

                var existingCliente = await _repository.BuscarPorId(IdCliente);
                if (existingCliente != null)
                {
                    clienteResponse.IdCliente = existingCliente.Id;
                    clienteResponse.NombreCliente = existingCliente.Nombre;
                    clienteResponse.ApellidoCliente = existingCliente.Apellido;
                    clienteResponse.DniCliente = existingCliente.NumDocumento;
                    clienteResponse.CorreoCliente = existingCliente.Correo;



                }
                else
                {
                    clienteResponse.NumeroError = 404;
                    clienteResponse.MensajeError = "El Id proporcionado es inválido o no existe.";

                }

            }
            catch (Exception ex)
            {

                clienteResponse.MensajeError = ex.Message;

            }
            finally
            {
                await _presenter.Handle(clienteResponse);
            }
        }
    }
}

