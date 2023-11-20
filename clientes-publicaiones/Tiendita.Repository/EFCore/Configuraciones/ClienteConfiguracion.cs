using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.EntityFrameworkCore.Extensions;
using reglasdenegocio.Entidades;
using System.Reflection.Emit;

namespace Tiendita.Repository.EFCore.Configuraciones
{
    internal class ClienteConfiguracion : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("clientes");

            builder.HasKey(a => a.Id); // Clave primaria.

            builder.Property(a => a.Id)
                .IsRequired()
                .HasColumnName("id_cliente") // Nombre de la columna en la base de datos MySQL.
                .HasColumnType("int") //Indica el tipo de dato de la columna en MySql.
                .UseMySQLAutoIncrementColumn("id_cliente");

            builder.Property(a => a.Nombre)
                .HasColumnName("nombre_cliente") 
                .HasColumnType("varchar") 
                .HasMaxLength(45)
                .IsRequired();

            builder.Property(a => a.Apellido)
                .HasColumnName("apellido_cliente") 
                .HasColumnType("varchar") 
                .HasMaxLength(45)
                .IsRequired();
            builder.Property(a => a.Correo)
                .HasColumnName("correo_cliente") 
                .HasColumnType("varchar") 
                .HasMaxLength(45)
                .IsRequired();
            builder.Property(a => a.NumDocumento)
                .HasColumnName("num_documento") 
                .HasColumnType("int") 
                .IsRequired();
            builder.Property(a => a.Contrasena)
                .HasColumnName("contrasena") 
                .HasColumnType("varchar") 
                .HasMaxLength(15)
                .IsRequired();
            builder.Property(a => a.Telefono)
                .HasColumnName("telefono") 
                .HasColumnType("varchar") 
                .HasMaxLength(15);
            builder.Property(a => a.Calle)
                .HasColumnName("calle") 
                .HasColumnType("varchar") 
                .HasMaxLength(45);
            builder.Property(a => a.Num_calle)
                .HasColumnName("num_calle") 
                .HasColumnType("int"); 

            builder.Property(a => a.NumDepartamento)
               .HasColumnName("num_departamento") 
               .HasColumnType("int"); 
             
            builder.Property(a => a.InformacionAdicional)
               .HasColumnName("informacion_adicional") 
               .HasColumnType("varchar") 
               .HasMaxLength(120);
            builder.Property(a => a.FechaCreacion)
               .HasColumnName("fecha_creacion") 
               .HasColumnType("DATETIME(0)")
               .IsRequired();
            builder.Property(a => a.FechaActualizacion)
               .HasColumnName("fecha_Actualizacion") 
               .IsRequired();
            builder.Property(a => a.IsDeleted)
            .HasColumnName("is_deleted") 
            .HasColumnType("bool")
            .IsRequired();

        }
    }
}
