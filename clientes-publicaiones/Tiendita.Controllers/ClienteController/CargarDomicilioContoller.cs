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
    public class CargarDomicilioContoller : ICargarDomicilioController
    {
        private readonly ICargarDomicilioClienteInputPort _cargarDomicilioInteractor;

        public CargarDomicilioContoller(ICargarDomicilioClienteInputPort cargarDomicilio)
        {
            _cargarDomicilioInteractor = cargarDomicilio;
        }

        public async Task<CargarDomicilioWRP> CargarDomicilo(CargarDomicilioDTO request)
        {
            try
            {
                await _cargarDomicilioInteractor.Handle(request);
                return new CargarDomicilioWRP
                {
                    MensajeError = "Cliente actualizado correctamente",
                };
            }
            catch (Exception ex)
            {
                return new CargarDomicilioWRP
                {
                    MensajeError = $"Error al actualizar el cliente: {ex.Message}",

                };
            }
        }
    }
}
