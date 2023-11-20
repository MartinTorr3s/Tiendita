using System.Security;

namespace Tiendita.ReglasdeNegocio.DTOs.ImagenDTOs
{
    public class ActualizarImagenDTO
    {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string Nombre { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public string Contrasena { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        //Actualizacion Algun Apartado de domicilio
        public string? Calle { get; set; }
        public short? Num_calle { get; set; }
        public short? NumDepartamento { get; set; }
        public string? InformacionAdicional { get; set; }

    }
}
