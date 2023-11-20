

using Tiendita.ReglasdeNegocio.Interfaces.Getways.PublicacionGetways.OuputPorts;
using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;

namespace Tiendita.ReglasdeNegocio.Interfaces.Presenters.PublicacionPresenters
{
    public interface ITraerTodasPublicacionesPresenter : ITraerTodasPublicacionesOutputPort
    {

        TraerTodasPublicacionesWRP Publicaciones { get; }
    }

}
