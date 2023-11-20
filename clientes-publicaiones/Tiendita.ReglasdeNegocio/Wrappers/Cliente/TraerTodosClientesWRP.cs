using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;

namespace Tiendita.ReglasdeNegocio.Wrappers.Cliente
{

    public class TraerTodosClientesWRP : BaseWrappers
    {
        public List<ClienteCosultaDTO>? Clientes { get; set; } = new List<ClienteCosultaDTO>();
    }

}


