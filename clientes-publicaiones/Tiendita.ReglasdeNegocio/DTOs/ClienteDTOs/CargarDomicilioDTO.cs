using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs
{
    public class CargarDomicilioDTO
    {
        public int IdCliente { get; set; }
        public string? CalleCliente { get; set; }
        public string? TelefonoCliente { get; set; }
        public short? NumCalleCliente { get; set; }
        public short? NumDepartamentoCliente { get; set; }
        public string? InformacionAdicionalCliente { get; set; }
    }
}
