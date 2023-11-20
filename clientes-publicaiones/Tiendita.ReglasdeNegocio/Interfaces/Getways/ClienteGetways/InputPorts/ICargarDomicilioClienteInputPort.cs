using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;

namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts
{
    public interface ICargarDomicilioClienteInputPort
    {
        Task Handle(CargarDomicilioDTO cargarDomicilioDTO);
    }
}
