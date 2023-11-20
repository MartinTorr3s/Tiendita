using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.ReglasdeNegocio.DTOs.ClienteDTOs;
using Tiendita.ReglasdeNegocio.Interfaces.Presenters.ClientePresenters;
using Tiendita.ReglasdeNegocio.Wrappers.Cliente;

namespace Tiendita.Presenters.Presenters.ClientePresenters
{
    public class TraerTodosClientesPresenter : ITraerTodosClientesPresenter
    {

        public TraerTodosClientesWRP Clientes { get; private set; }

        public ValueTask Handle(TraerTodosClientesWRP clientes)
        {
            Clientes = clientes;
            return ValueTask.CompletedTask;
        }
    }
}
