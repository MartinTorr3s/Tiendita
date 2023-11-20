using reglasdenegocio.Entidades;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface IClienteRepository
    {
        Task<Cliente> BuscarPorId(int IdCliente);
        Task Crear(Cliente cliente);
        Task Borrar(int IdCliente);
        Task Actualizar(Cliente cliente);
        Task CargarDomicilio(Cliente cliente);


        Task<List<Cliente>> TraerTodosLosClientes();
        Task GuardarCambios();  
    }
}
