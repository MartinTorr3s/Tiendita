
using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;


namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Publicaciones
{
    public interface IBorrarPublicacionController
    {
        Task<CrearBorrarPublicacionWRP> BorrarPublicacion(int idPublicacion);
    }
}
