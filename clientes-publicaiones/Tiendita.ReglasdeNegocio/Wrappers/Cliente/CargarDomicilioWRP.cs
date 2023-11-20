using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.validadorDTO;

namespace Tiendita.ReglasdeNegocio.Wrappers.Cliente
{
    public class CargarDomicilioWRP : BaseWrappers
    {
        public int IdCliente { get; set; }
        public string? CalleCliente { get; set; }
        public string? TelefonoCliente { get; set; }
        public short? NumCalleCliente { get; set; }
        public short? NumDepartamentoCliente { get; set; }
        public string? InformacionAdicionalCliente { get; set; }
        public List<ValidacionErroresDTO>? ValidationErrors { get; set; }
    }
}
