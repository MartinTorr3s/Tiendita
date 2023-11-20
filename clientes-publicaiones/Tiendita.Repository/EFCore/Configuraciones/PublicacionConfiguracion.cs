using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.EntityFrameworkCore.Extensions;
using reglasdenegocio.Entidades;

namespace Tiendita.Repository.EFCore.Configuraciones
{
    internal class PublicacionConfiguracion : IEntityTypeConfiguration<Publicacion>
    {
        public void Configure(EntityTypeBuilder<Publicacion> builder)
        {
            builder.ToTable("publicaciones");

            builder.HasKey(a => a.Id); // Clave primaria.

            builder.Property(a => a.Id)
                .IsRequired()
                .HasColumnName("id_publicacion") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") //Indica el tipo de dato de la columna en MySql.
                .UseMySQLAutoIncrementColumn("id_publicacion");

            builder.Property(a => a.NombrePublicacion)
                .HasColumnName("nombre_publicacion") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") //Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(45)
                .IsRequired();
            builder.Property(a => a.DescripcionPorducto)
                .HasColumnName("descripcion_producto") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("varchar") //Indica el tipo de dato de la columna en MySql.
                .HasMaxLength(150)
                .IsRequired();
            builder.Property(a => a.CantProductos)
                .HasColumnName("cant_productos") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") //Indica el tipo de dato de la columna en MySql.
                .IsRequired();

            builder.Property(a => a.FechaCreacion)
               .HasColumnName("fecha_creacion") // Nombre de la columna en la base de datos MySQL.
               .HasColumnType("DATETIME(0)") //Indica el tipo de dato de la columna en MySql.
               .IsRequired();
            builder.Property(a => a.FechaActualizacion)
               .HasColumnName("fecha_actualizacion") // Nombre de la columna en la base de datos MySQL.
               .HasColumnType("DATETIME(0)"); //Indica el tipo de dato de la columna en MySql.
          
        }
    }
}
