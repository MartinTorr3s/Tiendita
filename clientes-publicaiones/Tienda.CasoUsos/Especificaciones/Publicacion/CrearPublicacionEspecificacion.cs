using Tiendita.ReglasdeNegocio.DTOs.PublicacionDTOs;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;
using Tiendita.ReglasdeNegocio.Interfaces.ValidationSpecification;

namespace Tienda.CasoUsos.Especificaciones.Publicacion
{
    internal class CrearPublicacionEspecificacion : IEspecificacion<CrearPublicacionDTO>
    {
        readonly CrearPublicacionDTO _entity;
        readonly List<ValidacionErroresDTO> _errors = new List<ValidacionErroresDTO>();
        public CrearPublicacionEspecificacion(CrearPublicacionDTO entity)
        {
            this._entity = entity;
        }

        public List<ValidacionErroresDTO> Validar()
        {

            if (string.IsNullOrEmpty(_entity.NombrePublicacion))
            {
                _errors.Add(new ValidacionErroresDTO
                {
                    NombrePropiedad = "Nombre Publicacion",
                    MensajeError = "El campo no puede ser nulo ni vacío."
                });
            }

            if (string.IsNullOrEmpty(_entity.DescripcionPorducto))
            {
                _errors.Add(new ValidacionErroresDTO
                {
                    NombrePropiedad = "Descripcion del Producto",
                    MensajeError = "El campo no puede ser nulo ni vacío."
                });
            }
            if (_entity.CantProductos <= 0)
            {
                _errors.Add(new ValidacionErroresDTO
                {
                    NombrePropiedad = "Cantidad de Productos",
                    MensajeError = "El campo debe ser mayor que cero."
                });
            }

            return _errors;

        }
    }
}
