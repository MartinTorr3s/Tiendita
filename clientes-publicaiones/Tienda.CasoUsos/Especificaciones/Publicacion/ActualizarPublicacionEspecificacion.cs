using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;
using Tiendita.ReglasdeNegocio.Interfaces.ValidationSpecification;


namespace Tienda.CasoUsos.Especificaciones.Publicacion
{
    internal class ActualizarPublicacionEspecificacion : IEspecificacion<ActualizarPublicacionDTO>
    {
        readonly ActualizarPublicacionDTO _entity;
        readonly List<ValidacionErroresDTO> _errors = new List<ValidacionErroresDTO>();
        public ActualizarPublicacionEspecificacion(ActualizarPublicacionDTO entity)
        {
            _entity = entity;
        }

        public List<ValidacionErroresDTO> Validar()
        {
            if (_entity.IdPublicacion == 0)
            {
                _errors.Add(new ValidacionErroresDTO()
                {
                    NombrePropiedad = "Id",
                    MensajeError = "Problemas a la hora de encontrar Publicacion"
                });
            }

            return _errors;

        }

    }
}
