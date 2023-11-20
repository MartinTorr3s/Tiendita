using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;


namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts
{
    /// <summary>
    /// Este Input Port se encarga de manejar la creación de una nueva publicacion en el sistema. 
    /// </summary>
    public interface ICrearClienteInputPort
    {
        /// <summary>
        /// El método Handle recibiría un objeto CrearPublicacionDTO con el que se creara un
        /// nuevo registro en el contexto.
        /// </summary>
        /// <param name="crearClienteRequest">Contiene los detalles de la nueva Publicacion a crear.</param>
        Task Handle(CrearClienteDTO crearClienteRequest);
    }
}
