namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts
{

    public interface IBorrarClienteInputPort
    {

        Task Handle(int idCliente);
    }

}
