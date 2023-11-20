using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Cliente
{
    public class CrearBorrarClienteWRP : BaseWrappers
    {
        public int IdCliente { get; set; }
        public List<ValidacionErroresDTO>? ValidationErrors { get; set; }
    }
}

