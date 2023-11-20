using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;
using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;


namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Publicaciones
{
    public interface IActualizarPublicacionController
    {
        Task<CrearBorrarPublicacionWRP> ActualizarPublicacion(ActualizarPublicacionDTO request);
    }
}
