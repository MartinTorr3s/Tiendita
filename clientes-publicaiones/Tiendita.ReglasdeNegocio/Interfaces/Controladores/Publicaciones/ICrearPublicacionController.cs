
using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;
using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Publicaciones
{
    public interface ICrearPublicacionController
    {
        Task<CrearBorrarPublicacionWRP> CrearPublicacion(CrearPublicacionDTO request);
    }
}
