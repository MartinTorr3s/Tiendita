using reglasdenegocio.Entidades;
using Tienda.CasoUsos.Especificaciones.Publicacion;
using Tiendita.BusinessRules.Interfaces.Getways.PublicacionGetways.InputPorts;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;
using Tiendita.ReglasdeNegocio.Interfaces.Getways.ClienteGetways.InputPorts;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.PublicacionPresenters;
using Tiendita.ReglasdeNegocio.PersonalException;
using Tiendita.ReglasdeNegocio.Wrappers.Publicaciones;

namespace Tienda.CasoUsos.CasosUsos.PublicacionCasoUso
{
    internal class CrearPublicacionIteractor : ICrearPublicacionInputPort
    {
        readonly PublicacionRepository _repository;
        readonly ICrearPublicacionPresenter _presenter;
        public CrearPublicacionIteractor(PublicacionRepository repository, ICrearPublicacionPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }
        public async Task Handle(CrearPublicacionDTO crearPublicacionDTO)
        {
            List<ValidacionErroresDTO> errors = new List<ValidacionErroresDTO>();
            errors = ValidarCliente(crearPublicacionDTO);
            CrearBorrarPublicacionWRP PublicacionRespuesta = new();

            if (errors.Any())
            {
                PublicacionRespuesta.ValidationErrors = errors;
                await _presenter.Handle(PublicacionRespuesta);
                return;
            }



            Publicacion newPublicacion = new()
            {
                NombrePublicacion = crearPublicacionDTO.NombrePublicacion
            };

            try
            {
                await _repository.Crear(newPublicacion);
                await _repository.GuardarCambios();
                PublicacionRespuesta.IdPublicacion = newPublicacion.Id;
            }
            catch (DBMySqlException ex)
            {
                PublicacionRespuesta.NumeroError = ex.Number;
                PublicacionRespuesta.MensajeError = ex.MessageError;
            }
            finally
            {
                await _presenter.Handle(PublicacionRespuesta);
            }

        }
        private List<ValidacionErroresDTO> ValidarCliente(CrearPublicacionDTO crearPublicacionDTO)
        {
            var specification = new CrearPublicacionEspecificacion(crearPublicacionDTO);
            return specification.Validar();
        }
    }
}
