using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;
using Tiendita.ReglasdeNegocio.Interfaces.ValidationSpecification;

namespace Tienda.CasoUsos.Especificaciones.Cliente
{
    public class CrearClienteEspecificaciones : IEspecificacion<CrearClienteDTO>
    {
        readonly CrearClienteDTO _entity;
        readonly List<ValidacionErroresDTO> _errors = new List<ValidacionErroresDTO>();
        public CrearClienteEspecificaciones(CrearClienteDTO entity)
        {
            this._entity = entity;
        }

        public List<ValidacionErroresDTO> Validar()
        {
            if (string.IsNullOrEmpty(_entity.Nombre))
            {
                _errors.Add(new ValidacionErroresDTO
                {
                    NombrePropiedad = "Nombre Cliente",
                    MensajeError = "El campo no puede ser nulo ni vacío."

                });
            }
            else if (_entity.Nombre.Length > 45)
            {
                _errors.Add(new ValidacionErroresDTO
                {
                    NombrePropiedad = "Nombre Cliente",
                    MensajeError = "El campo no puede contener más de 45 caracteres."
                });

            }

            foreach (char i in _entity.Nombre)
            {
                if (char.IsDigit(i))
                {
                    _errors.Add(new ValidacionErroresDTO
                    {
                        NombrePropiedad = "Nombre Cliente",
                        MensajeError = "El campo no puede Contener Un numero."
                    });
                    break;
                }
            }

            return _errors;
        }
    }
}

