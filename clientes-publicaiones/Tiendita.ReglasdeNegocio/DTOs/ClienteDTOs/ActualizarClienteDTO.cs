using System.Security;

namespace Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs
{
    public class ActualizarClienteDTO
    {
        public int IdCliente { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        //public SecureString Contrasena { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        //public string Nombre { get; set; }
        //Actualizacion Algun Apartado de domicilio
        public string? CalleCliente { get; set; }
        public string? TelefonoCliente { get; set; }
        public short? NumCalleCliente{ get; set; }
        public short? NumDepartamentoCliente { get; set; }
        public string? InformacionAdicionalCliente { get; set; }

    }
}
