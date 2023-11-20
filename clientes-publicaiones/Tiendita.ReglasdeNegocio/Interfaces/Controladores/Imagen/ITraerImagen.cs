using Tiendita.ReglasdeNegocio.Wrappers.Imagen;

namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Imagen
{
    public interface ITraerImagen
    {
        Task<TraerImagenWRP> TraerImagen(int IdCliente);
    }
}
