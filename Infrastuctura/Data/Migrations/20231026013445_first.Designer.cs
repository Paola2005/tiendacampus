﻿// <auto-generated />
using System;
using Infrastuctura.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastuctura.Data.Migrations
{
    [DbContext(typeof(TiendaCampusContext))]
    [Migration("20231026013445_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamento")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamento");

                    b.ToTable("Ciudad", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ContactoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoContacto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPersona");

                    b.HasIndex("IdTipoContacto");

                    b.ToTable("ContactoPersona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Idpais")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Idpais");

                    b.ToTable("Depatamento", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DetalleMovimientoInventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdInventario")
                        .HasColumnType("int");

                    b.Property<int>("IdMovimientoInventario")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdInventario");

                    b.HasIndex("IdMovimientoInventario");

                    b.ToTable("DetalleMovimientoInventario", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FacturaActual")
                        .HasColumnType("int");

                    b.Property<int>("FacturaInicial")
                        .HasColumnType("int");

                    b.Property<string>("NroResolucion")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Factura", (string)null);
                });

            modelBuilder.Entity("Core.Entities.FormaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("FormaPago", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPresentacion")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("StockMax")
                        .HasColumnType("int");

                    b.Property<int>("StockMin")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPresentacion");

                    b.HasIndex("IdProducto");

                    b.ToTable("Inventario", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Marca", (string)null);
                });

            modelBuilder.Entity("Core.Entities.MovimientoInventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaMovimiento")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaVencimiento")
                        .HasColumnType("date");

                    b.Property<int>("IdReceptor")
                        .HasColumnType("int");

                    b.Property<int>("IdResponsable")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoMovimientoInventario")
                        .HasColumnType("int");

                    b.Property<int?>("Personas2Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdResponsable");

                    b.HasIndex("IdTipoMovimientoInventario");

                    b.HasIndex("Personas2Id");

                    b.ToTable("MovimientoInventario", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Pais", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaRegistro")
                        .HasColumnType("date");

                    b.Property<int>("IdDocumento")
                        .HasColumnType("int");

                    b.Property<int>("IdRolPersona")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersona")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDocumento");

                    b.HasIndex("IdRolPersona");

                    b.HasIndex("IdTipoPersona");

                    b.ToTable("Persona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Presentacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Presentacion", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdMarca");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("Core.Entities.RolPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RolPersona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoContacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TipoContacto", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumento", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoMovimientoInventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TipoMovimientoInventario", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TipoPersona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.UbicacionPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bis")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cardinal")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CardinalSec")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CodigoPostal")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("IdCiudad")
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<string>("Letra")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("LetraSec")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("LetraTer")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<int>("NumeroPri")
                        .HasColumnType("int");

                    b.Property<int>("NumeroSec")
                        .HasColumnType("int");

                    b.Property<int>("NumeroTer")
                        .HasColumnType("int");

                    b.Property<string>("TipoDeVia")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudad");

                    b.HasIndex("IdPersona");

                    b.ToTable("UbicacionPersona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.HasOne("Core.Entities.Departamento", "Departamentos")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepartamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Core.Entities.ContactoPersona", b =>
                {
                    b.HasOne("Core.Entities.Persona", "Personas")
                        .WithMany("ContactosPersonas")
                        .HasForeignKey("IdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoContacto", "TiposContactos")
                        .WithMany("ContactosPersonas")
                        .HasForeignKey("IdTipoContacto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personas");

                    b.Navigation("TiposContactos");
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.HasOne("Core.Entities.Pais", "Paises")
                        .WithMany("Departamentos")
                        .HasForeignKey("Idpais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paises");
                });

            modelBuilder.Entity("Core.Entities.DetalleMovimientoInventario", b =>
                {
                    b.HasOne("Core.Entities.Inventario", "Inventarios")
                        .WithMany("DetallesMovimientosInventarios")
                        .HasForeignKey("IdInventario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.MovimientoInventario", "MovimientosInventarios")
                        .WithMany("DetallesMovimientosInventarios")
                        .HasForeignKey("IdMovimientoInventario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventarios");

                    b.Navigation("MovimientosInventarios");
                });

            modelBuilder.Entity("Core.Entities.Inventario", b =>
                {
                    b.HasOne("Core.Entities.Presentacion", "Presentaciones")
                        .WithMany("Inventarios")
                        .HasForeignKey("IdPresentacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Producto", "Productos")
                        .WithMany("Inventarios")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Presentaciones");

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Core.Entities.MovimientoInventario", b =>
                {
                    b.HasOne("Core.Entities.Persona", "Personas")
                        .WithMany("MovimientoInventarios")
                        .HasForeignKey("IdResponsable")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoMovimientoInventario", "TiposMovimientosInventarios")
                        .WithMany("MovimientoInventarios")
                        .HasForeignKey("IdTipoMovimientoInventario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Persona", "Personas2")
                        .WithMany()
                        .HasForeignKey("Personas2Id");

                    b.Navigation("Personas");

                    b.Navigation("Personas2");

                    b.Navigation("TiposMovimientosInventarios");
                });

            modelBuilder.Entity("Core.Entities.Persona", b =>
                {
                    b.HasOne("Core.Entities.TipoDocumento", "TiposDocumentos")
                        .WithMany("Personas")
                        .HasForeignKey("IdDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.RolPersona", "RolesPersonas")
                        .WithMany("Personas")
                        .HasForeignKey("IdRolPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.TipoPersona", "TiposPersonas")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RolesPersonas");

                    b.Navigation("TiposDocumentos");

                    b.Navigation("TiposPersonas");
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.HasOne("Core.Entities.Marca", "Marcas")
                        .WithMany("Productos")
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marcas");
                });

            modelBuilder.Entity("Core.Entities.UbicacionPersona", b =>
                {
                    b.HasOne("Core.Entities.Ciudad", "Ciudades")
                        .WithMany("UbicacionPersonas")
                        .HasForeignKey("IdCiudad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Persona", "Personas")
                        .WithMany("UbicacionPersonas")
                        .HasForeignKey("IdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudades");

                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.Navigation("UbicacionPersonas");
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Core.Entities.Inventario", b =>
                {
                    b.Navigation("DetallesMovimientosInventarios");
                });

            modelBuilder.Entity("Core.Entities.Marca", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Core.Entities.MovimientoInventario", b =>
                {
                    b.Navigation("DetallesMovimientosInventarios");
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Core.Entities.Persona", b =>
                {
                    b.Navigation("ContactosPersonas");

                    b.Navigation("MovimientoInventarios");

                    b.Navigation("UbicacionPersonas");
                });

            modelBuilder.Entity("Core.Entities.Presentacion", b =>
                {
                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Core.Entities.RolPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Core.Entities.TipoContacto", b =>
                {
                    b.Navigation("ContactosPersonas");
                });

            modelBuilder.Entity("Core.Entities.TipoDocumento", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Core.Entities.TipoMovimientoInventario", b =>
                {
                    b.Navigation("MovimientoInventarios");
                });

            modelBuilder.Entity("Core.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
