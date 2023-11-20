using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente
{
    public interface ITraerTodosClientesController
    {
        ValueTask<TraerTodosClientesWRP> TraerTodosClientes();
    }
}
