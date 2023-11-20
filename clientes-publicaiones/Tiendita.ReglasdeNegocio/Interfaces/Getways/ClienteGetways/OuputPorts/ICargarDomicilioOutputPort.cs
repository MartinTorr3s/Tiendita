using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.OuputPorts
{
    public interface ICargarDomicilioOutputPort
    {
        Task Handle(CargarDomicilioWRP Cliente);
    }
}
