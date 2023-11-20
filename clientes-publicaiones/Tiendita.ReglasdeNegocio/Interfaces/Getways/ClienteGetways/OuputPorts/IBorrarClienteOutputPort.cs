using Tiendita.ReglasdeNegocio.Wrappers.Cliente;


namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.OuputPorts
{

    public interface IBorrarClienteOutputPort
    {

        Task Handle(BorrarClienteWRP cliente);
    }

}
