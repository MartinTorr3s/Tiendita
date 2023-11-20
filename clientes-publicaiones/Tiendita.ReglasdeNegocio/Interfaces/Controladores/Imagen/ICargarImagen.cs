using Tiendita.ReglasdeNegocio.DTOs.ImagenDTOs;
using Tiendita.ReglasdeNegocio.Wrappers.Imagen;


namespace Tiendita.ReglasdeNegocio.Interfaces.Controladores.Imagen
{
    internal interface ICargarImagen
    {
        Task<CargarImagenWRP> CargarImagen(CargarImagenDTO request);
    }
}
