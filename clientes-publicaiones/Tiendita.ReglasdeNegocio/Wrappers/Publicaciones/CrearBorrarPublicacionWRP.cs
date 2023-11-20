using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Publicaciones
{
    public class CrearBorrarPublicacionWRP : BaseWrappers
    {
        public int IdPublicacion { get; set; }
        public List<ValidacionErroresDTO>? ValidationErrors { get; set; }
    }
}
