﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tiendita.Repository.Contexto;

#nullable disable

namespace Tiendita.Repository.Migrations
{
    [DbContext(typeof(TienditaContexto))]
    partial class TienditaContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Tiendita.Entity.Entidades.Imagen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<int?>("PublicacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PublicacionId");

                    b.ToTable("Imagen");
                });

            modelBuilder.Entity("reglasdenegocio.Entidades.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Calle")
                        .HasColumnType("longtext");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<string>("InformacionAdicional")
                        .HasColumnType("longtext");

                    //b.Property<int?>("MetodoPago")
                    //    .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<short?>("NumDepartamento")
                        .HasColumnType("smallint");

                    b.Property<int>("NumDocumento")
                        .HasColumnType("int");

                    b.Property<short?>("Num_calle")
                        .HasColumnType("smallint");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("reglasdenegocio.Entidades.Publicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ActualizadoPor")
                        .HasColumnType("int");

                    b.Property<short>("CantProductos")
                        .HasColumnType("smallint");

                    b.Property<int>("CreadoPor")
                        .HasColumnType("int");

                    b.Property<string>("DescripcionPorducto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<string>("NombrePublicacion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("publicaciones");
                });

            modelBuilder.Entity("Tiendita.Entity.Entidades.Imagen", b =>
                {
                    b.HasOne("reglasdenegocio.Entidades.Publicacion", null)
                        .WithMany("imagenes")
                        .HasForeignKey("PublicacionId");
                });

            modelBuilder.Entity("reglasdenegocio.Entidades.Publicacion", b =>
                {
                    b.Navigation("imagenes");
                });
#pragma warning restore 612, 618
        }
    }
}