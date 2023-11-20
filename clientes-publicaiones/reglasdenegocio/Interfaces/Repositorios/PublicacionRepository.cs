using reglasdenegocio.Entidades;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface PublicacionRepository
    {
        Task BuscarPor(int id);
        Task Crear(Publicacion publicacion);
        Task Borrar(int id);
        Task Modificar(Publicacion publicacion);
        Task GuardarCambios();
        Task<List<Publicacion>> TraerTodasLasPublicaciones();
    }
}
