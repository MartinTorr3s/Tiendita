using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.Controllers.ClienteController
{
    public class ActualizarClienteController : IActualizarClienteController
    {
        private readonly IActualizarClienteInputPor _actualizarClienteInteractor;

        public ActualizarClienteController(IActualizarClienteInputPor actualizarClienteInteractor)
        {
            _actualizarClienteInteractor = actualizarClienteInteractor;
        }

        public async Task<CrearBorrarClienteWRP> ActualizarCliente(ActualizarClienteDTO request)
        {
            try
            {
                await _actualizarClienteInteractor.Handle(request);
                return new CrearBorrarClienteWRP
                {
                    MensajeError = "Cliente actualizado correctamente",
                };
            }
            catch (Exception ex)
            {
                return new CrearBorrarClienteWRP
                {
                    MensajeError = $"Error al actualizar el cliente: {ex.Message}",
                    
                };
            }
        }
    }
}
