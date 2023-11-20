using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente
{
    public interface ICargarDomicilioController
    {   
        Task<CargarDomicilioWRP> CargarDomicilo(CargarDomicilioDTO request);
    }
}
