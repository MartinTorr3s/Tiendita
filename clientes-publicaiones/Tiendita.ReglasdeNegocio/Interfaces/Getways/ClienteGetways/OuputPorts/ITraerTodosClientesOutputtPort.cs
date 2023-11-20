using Tiendita.ReglasdeNegocio.Wrappers.Cliente;


namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.OuputPorts
{
    /// <summary>
    /// Este Input Port se encarga de recuperar una lista de todas las publicaciones disponibles en el contexto.
    /// </summary>
    public interface ITraerTodosClientesOuputPort
    {
        /// <summary>
        ///  El método Handle ejecuta una query en el contexto para obtener el contenido de
        ///  la tabla publicaciones.
        /// </summary>
        /// <returns>Colección de objetos que representan a todas las publicaciones.</returns>
        ValueTask Handle(TraerTodosClientesWRP Clientes);
    }

}
