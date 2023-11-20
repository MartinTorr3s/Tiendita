using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public class CargarDomicilioIteractor : ICargarDomicilioClienteInputPort
    {
        private readonly IClienteRepository _repository;
        private readonly ICargarDomicilioPresenter _presenter;

        public CargarDomicilioIteractor(IClienteRepository repository, ICargarDomicilioPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(CargarDomicilioDTO cargarDomicilioDTO)
        {
            List<ValidacionErroresDTO> errors = new List<ValidacionErroresDTO>();
            CargarDomicilioWRP clienteWRP = new();
            try
            {

                errors = Validar(cargarDomicilioDTO);

                if (errors.Any())
                {
                    clienteWRP.ValidationErrors = errors;
                    await _presenter.Handle(clienteWRP);
                    return;
                }


                Cliente existenciaCliente = await _repository.BuscarPorId(cargarDomicilioDTO.IdCliente);
                if (existenciaCliente == null)
                {

                    clienteWRP.NumeroError = 404;
                    clienteWRP.MensajeError = $"no se encontro cliente {cargarDomicilioDTO.IdCliente}";
                    await _presenter.Handle(clienteWRP);
                    return;
                }


                existenciaCliente.Telefono = cargarDomicilioDTO.TelefonoCliente;
                existenciaCliente.Calle = cargarDomicilioDTO.CalleCliente;
                existenciaCliente.Num_calle = cargarDomicilioDTO.NumCalleCliente;
                existenciaCliente.NumDepartamento = cargarDomicilioDTO.NumDepartamentoCliente;
                existenciaCliente.InformacionAdicional = cargarDomicilioDTO.InformacionAdicionalCliente;



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

        private List<ValidacionErroresDTO> Validar(CargarDomicilioDTO cargarDomicilioDTO)
        {
            var specification = new CargarDomicilioEspecificaciones(cargarDomicilioDTO);
            return specification.Validar();
        }
    }
}

