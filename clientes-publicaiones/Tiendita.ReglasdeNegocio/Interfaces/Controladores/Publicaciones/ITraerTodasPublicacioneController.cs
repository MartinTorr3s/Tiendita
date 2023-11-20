using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;


namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Publicaciones
{
    public interface ITraerTodasPublicacioneController
    {
        ValueTask<TraerTodasPublicacionesWRP> TraerTodasPublicaciones();
    }
}
