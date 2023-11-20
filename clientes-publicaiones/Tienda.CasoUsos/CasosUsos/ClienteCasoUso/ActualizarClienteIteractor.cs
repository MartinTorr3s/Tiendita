using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Tienda.CasoUsos.Especificaciones.Cliente;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tienda.CasoUsos.CasosUsos.ClienteCasoUso
{
    public class ActualizarClienteIteractor : IActualizarClienteInputPor
    {
        private readonly IClienteRepository _repository;
        private readonly IActualizarClientePresenter _presenter;

        public ActualizarClienteIteractor(IClienteRepository repository, IActualizarClientePresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(ActualizarClienteDTO actualizarClienteDTO)
        {
            List<ValidacionErroresDTO> errors = new List<ValidacionErroresDTO>();
            ActualizarClienteWRP clienteWRP = new();

            try
            {
                
                errors = Validar(actualizarClienteDTO);

                if (errors.Any())
                {
                    
                    clienteWRP.ValidationErrors = errors;
                    await _presenter.Handle(clienteWRP);
                    return;
                }

                
                Cliente existenciaCliente = await _repository.BuscarPorId(actualizarClienteDTO.IdCliente);
                if (existenciaCliente == null)
                {
                   
                    clienteWRP.NumeroError = 404;
                    clienteWRP.MensajeError = $"no se encontro cliente {actualizarClienteDTO.IdCliente}";
                    await _presenter.Handle(clienteWRP);
                    return;
                }

               
                existenciaCliente.Telefono= actualizarClienteDTO.TelefonoCliente;
                existenciaCliente.Calle = actualizarClienteDTO.CalleCliente;
                existenciaCliente.Num_calle = actualizarClienteDTO.NumCalleCliente;
                existenciaCliente.NumDepartamento = actualizarClienteDTO.NumDepartamentoCliente;
                existenciaCliente.InformacionAdicional = actualizarClienteDTO.InformacionAdicionalCliente;


                
                await _repository.Actualizar(existenciaCliente);
                await _repository.GuardarCambios();

                
                //clienteWRP.IdCliente = existenciaCliente.Id;
                //clienteWRP.NombreCliente = existenciaCliente.Nombre;

               
                await _presenter.Handle(clienteWRP);
            }
            catch (Exception ex)
            {
                
                clienteWRP.MensajeError = ex.Message;
            }
            finally
            {
                await _presenter.Handle(clienteWRP);
            }
        }

        private List<ValidacionErroresDTO> Validar(ActualizarClienteDTO actualizarClienteDTO)
        {
            var specification = new ActualizarClienteEspecificaciones(actualizarClienteDTO);
            return specification.Validar();
        }
    }

}

