
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;


namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente
{
    public interface IBorrarClienteController
    {
        Task<BorrarClienteWRP> BorrarCliente(int IdCliente);
    }
}
