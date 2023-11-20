namespace Tiendita.ReglasdeNegocio.Wrappers.Publicaciones
{

    public class TraerTodasPublicacionesWRP : BaseWrappers
    {
        public List<Publicacion>? Publicaciones { get; set; } = new List<Publicacion>();

        public class Publicacion
        {
            public int IdPublicacion { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
            public string NombrePublicacion { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        }
    }
}


