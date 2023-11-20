using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;
namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Cliente
{
    public interface IActualizarClienteController
    {
        Task<CrearBorrarClienteWRP> ActualizarCliente(ActualizarClienteDTO request);
    }
}
