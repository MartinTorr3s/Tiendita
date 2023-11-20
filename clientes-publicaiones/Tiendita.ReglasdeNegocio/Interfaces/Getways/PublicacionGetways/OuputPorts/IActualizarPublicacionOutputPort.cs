using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;

namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.PublicacionGetways.OuputPorts
{
    /// <summary>
    /// Este Input Port se utiliza para manejar la actualización de la información de una publicacion
    /// existente. 
    /// </summary>
    public interface IActualizarPublicacionOutputPort
    {
        /// <summary>
        /// El método Handle recibe un objeto ActualizarPublicacionDTO con información para
        /// actualizar en elcontexto.
        /// </summary>
        /// <param name="ActualizarPublicacionRequest">Contiene los detalles actualizados de la publicacion,
        /// incluido el Id de la publicacion que se debe actualizar.</param>
        Task Handle(ActualizarPublicacionDTO Publicacion);
    }

}
