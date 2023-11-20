using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Cliente
{
    public class ActualizarClienteWRP : BaseWrappers
    {
        public int IdCliente { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        //public string NombreCliente { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string? CalleCliente { get; set; }
        public string? TelefonoCliente { get; set; }
        public short? NumCalleCliente { get; set; }
        public short? NumDepartamentoCliente { get; set; }
        public string? InformacionAdicionalCliente { get; set; }
        public List<ValidacionErroresDTO>? ValidationErrors { get; set; }
    }
}
