using Tiendita.BusinessRules.Interfaces.Getways.PublicacionGetways.InputPorts;
using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;
using Tiendita.ReglasdeNegocio.Interfaces.Controladores.Publicaciones;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.PublicacionPresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;

namespace Tiendita.Controllers.PublicacionController
{
    internal class CrearPublicacionController : ICrearPublicacionController
    {

        readonly ICrearPublicacionInputPort _inputPort;
        readonly ICrearPublicacionPresenter _presenter;

        public CrearPublicacionController(ICrearPublicacionInputPort inputPort, ICrearPublicacionPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }
        public async Task<CrearBorrarPublicacionWRP> CrearPublicacion(CrearPublicacionDTO request)
        {
            await _inputPort.Handle(request);
            return _presenter.Publicacion;
        }

    }
}
