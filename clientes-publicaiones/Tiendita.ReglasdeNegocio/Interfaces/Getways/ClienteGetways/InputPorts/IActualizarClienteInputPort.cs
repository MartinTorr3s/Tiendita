using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;

namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts
{
    /// <summary>
    /// Este Input Port se utiliza para manejar la actualización de la información de una publicacion
    /// existente. 
    /// </summary>
    public interface IActualizarClienteInputPor
    {
        /// <summary>
        /// El método Handle recibe un objeto ActualizarPublicacionDTO con información para
        /// actualizar en elcontexto.
        /// </summary>
        /// <param name="ActualizarClienteRequest">Contiene los detalles actualizados de la publicacion,
        /// incluido el Id de la publicacion que se debe actualizar.</param>
        Task Handle(ActualizarClienteDTO ActualizarClienteRequest);
    }

}
