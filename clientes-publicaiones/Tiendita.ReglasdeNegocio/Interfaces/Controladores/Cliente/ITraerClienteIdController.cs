using Tiendita.ReglasdeNegocio.Wrappers.Cliente;


namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente
{
    public interface ITraerClienteIdController
    {
        Task<TraerClienteWRP> TraerCliente(int IdCliente);
    }
}
