

using Tiendita.ReglasdeNegocio.Interfaces.Getways.PublicacionGetways.OuputPorts;
using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;

namespace Tiendita.ReglasdeNegocio.Interfaces.Presenters.PublicacionPresenters
{

    public interface ICrearPublicacionPresenter : ICrearPublicacionOutputPort
    {

        CrearBorrarPublicacionWRP Publicacion { get; }
    }
}
