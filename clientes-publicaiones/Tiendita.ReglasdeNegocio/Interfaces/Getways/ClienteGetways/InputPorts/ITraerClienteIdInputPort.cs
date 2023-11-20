namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts
{
    /// <summary>
    /// Este Input Port se utiliza para recuperar información sobre una publicacion 
    /// específico en función de su Id.
    /// </summary>
    public interface ITraerClienteIdInputPort
    {
        /// <summary>
        /// El método Handle recibiría el Id de la publicacion y devolvería un objeto que 
        /// contiene los detalles de la publicacion.
        /// </summary>
        /// <param name="IdPublicacion">Id de la publicacion a buscar.</param>
        /// <returns>Detalles de la publicacion.</returns>
        Task Handle(int IdCliente);
    }

}
