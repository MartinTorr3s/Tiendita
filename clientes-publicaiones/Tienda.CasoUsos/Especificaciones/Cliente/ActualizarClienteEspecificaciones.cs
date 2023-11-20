using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;
using Tiendita.ReglasdeNegocio.Interfaces.ValidationSpecification;

namespace Tienda.CasoUsos.Especificaciones.Cliente
{
    internal class ActualizarClienteEspecificaciones : IEspecificacion<ActualizarClienteDTO>
    {
        readonly ActualizarClienteDTO _entity;
        readonly List<ValidacionErroresDTO> _errors = new List<ValidacionErroresDTO>();
        public ActualizarClienteEspecificaciones(ActualizarClienteDTO entity)
        {
            _entity = entity;
        }

        public List<ValidacionErroresDTO> Validar()
        {
            if (_entity.IdCliente == 0)
            {
                _errors.Add(new ValidacionErroresDTO()
                {
                    NombrePropiedad = "Id",
                    MensajeError = "Problemas a la hora de encontrar Cliente"
                });
            }

            //if (string.IsNullOrEmpty(_entity.Nombre))
            //{
            //    _errors.Add(new ValidacionErroresDTO
            //    {
            //        NombrePropiedad = "Nombre Cliente",
            //        MensajeError = "El campo no puede ser nulo ni vacío."

            //    });
            //}
            //if (_entity.Nombre.Length > 45)
            //{
            //    _errors.Add(new ValidacionErroresDTO
            //    {
            //        NombrePropiedad = "Nombre Cliente",
            //        MensajeError = "El campo no puede contener más de 45 caracteres."
            //    });

            //}

            return _errors;

        }

    }
}




