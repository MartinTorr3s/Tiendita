
using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente
{
    public interface ICrearClienteController
    {
        Task<CrearBorrarClienteWRP> CrearCliente(CrearClienteDTO request);
    }
}
