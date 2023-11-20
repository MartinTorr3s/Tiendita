using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;

namespace Tiendita.BusinessRules.Interfaces.Getways.PublicacionGetways.InputPorts
{
    /// <summary>
    /// Este Input Port se encarga de manejar la creación de una nueva publicacion en el sistema. 
    /// </summary>
    public interface ICrearPublicacionInputPort
    {
        /// <summary>
        /// El método Handle recibiría un objeto CrearPublicacionDTO con el que se creara un
        /// nuevo registro en el contexto.
        /// </summary>
        /// <param name="crearPublicacionRequest">Contiene los detalles de la nueva Publicacion a crear.</param>
        Task Handle(CrearPublicacionDTO crearPublicacionRequest);
    }
}
