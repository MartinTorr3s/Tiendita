using Tiendita.ReglasdeNegocio.Wrappers.Cliente;


namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.OuputPorts
{
    /// <summary>
    /// Este Input Port se encarga de manejar la creación de una nueva publicacion en el sistema. 
    /// </summary>
    public interface ICrearClienteOutputPort
    {
        /// <summary>
        /// El método Handle recibiría un objeto CrearPublicacionDTO con el que se creara un
        /// nuevo registro en el contexto.
        /// </summary>
        /// <param name="Cliente">Contiene los detalles de la nueva Publicacion a crear.</param>
        Task Handle(CrearBorrarClienteWRP Cliente);
    }
}
