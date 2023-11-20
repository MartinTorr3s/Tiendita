using Microsoft.EntityFrameworkCore;
using reglasdenegocio.Entidades;
using System.Reflection;
using Tiendita.Repository.EFCore.Configuraciones;

namespace Tiendita.Repository.Contexto
{
    public class TienditaContexto : DbContext
    {

        public TienditaContexto(DbContextOptions<TienditaContexto> options) : base(options) { }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Publicacion> publicaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica configuraciones de entidades desde el ensamblado actual.
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfiguration(new ClienteConfiguracion());
        }
        

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.ApplyConfigurationsFromAssembly(
        //        Assembly.GetExecutingAssembly());
        //}
    }
}