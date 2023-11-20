namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts
{
    /// <summary>
    /// Este Input Port se encarga de recuperar una lista de todas las publicaciones disponibles en el contexto.
    /// </summary>
    public interface ITraerTodosClientesInputPort
    {
        /// <summary>
        ///  El método Handle ejecuta una query en el contexto para obtener el contenido de
        ///  la tabla publicaciones.
        /// </summary>

        ValueTask Handle();
    }

}
