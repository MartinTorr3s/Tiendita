using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.OuputPorts;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters
{
    public interface ICargarDomicilioPresenter : ICargarDomicilioOutputPort
    {
        CargarDomicilioWRP Cliente { get; }
    }
}
