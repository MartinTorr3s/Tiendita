using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;
using Tiendita.ReglasdeNegocio.Interfaces.ValidationSpecification;

namespace Tienda.CasoUsos.Especificaciones.Cliente
{
    public class CargarDomicilioEspecificaciones : IEspecificacion<CargarDomicilioDTO>
    {
        readonly CargarDomicilioDTO _entity;
        readonly List<ValidacionErroresDTO> _errors = new List<ValidacionErroresDTO>();
        public CargarDomicilioEspecificaciones(CargarDomicilioDTO entity)
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
            return _errors;
        }
    }
}

