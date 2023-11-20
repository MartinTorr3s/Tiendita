namespace Tiendita.BusinessRules.Interfaces.Getways.PublicacionGetways.InputPorts
{
    /// <summary>
    /// Este Input Port se encarga de manejar la eliminación de una publicacion.
    /// </summary>
    public interface IBorrarPublicacionInputPort
    {
        /// <summary>
        /// El método Handle elimina una publicacion del contexto en base a su Id.
        /// </summary>
        /// <param name="IdPublicacion">Id de la publicacion que se debe eliminar.</param>
        /// <returns></returns>
        Task Handle(int IdPublicacion);
    }

}
