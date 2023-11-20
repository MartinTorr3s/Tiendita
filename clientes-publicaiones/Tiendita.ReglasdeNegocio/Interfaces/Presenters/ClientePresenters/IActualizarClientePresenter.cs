using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.OuputPorts;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;



namespace Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters
{

    public interface IActualizarClientePresenter : IActualizarClienteOutputPort
    {
        ActualizarClienteWRP Cliente { get; }
    }

}
