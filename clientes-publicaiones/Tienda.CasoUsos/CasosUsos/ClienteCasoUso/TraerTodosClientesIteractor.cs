using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.PersonalException;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tienda.CasoUsos.CasosUsos.ClienteCasoUso
{
    public class TraerTodosClientesIteractor : ITraerTodosClientesInputPort
    {
        private readonly IClienteRepository _repository;
        private readonly ITraerTodosClientesPresenter _presenter;

        public TraerTodosClientesIteractor(IClienteRepository repository, ITraerTodosClientesPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }
      
        public async ValueTask Handle()
        {
            TraerTodosClientesWRP clientesWRP = new();
            try
            {
                var existenClientes = await _repository.TraerTodosLosClientes();

                if (existenClientes != null && existenClientes.Count > 0)
                {
                    foreach (var cliente in existenClientes)
                    {
                        clientesWRP.Clientes.Add(new ClienteCosultaDTO
                        {
                            IdCliente = cliente.Id,
                            Nombre = cliente.Nombre,
                            Apellido = cliente.Apellido,
                            Correo= cliente.Correo,
                            NumDocumento = cliente.NumDocumento,

                        });
                    }
                }
                else
                {
                    clientesWRP.NumeroError = 404;
                    clientesWRP.MensajeError = "No existen registros en la tabla Clientes.";
                }

            }
            catch (DBMySqlException ex)
            {
                clientesWRP.NumeroError = ex.Number;
                clientesWRP.MensajeError = ex.MessageError;

            }
            finally
            {
                await _presenter.Handle(clientesWRP);
            }
        }
    }
}
