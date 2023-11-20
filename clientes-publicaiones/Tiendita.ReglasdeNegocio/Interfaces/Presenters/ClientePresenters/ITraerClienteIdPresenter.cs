
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.OuputPorts;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters
{
    public interface ITraerClienteIdPresenter : ITraerClienteIdOutputPort
    {
  
        TraerClienteWRP Cliente { get; }
    }

}
