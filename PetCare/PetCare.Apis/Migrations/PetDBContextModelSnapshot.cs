﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetCare.Apis.Data;

#nullable disable

namespace PetCare.Apis.Migrations
{
    [DbContext(typeof(PetDBContext))]
    partial class PetDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetCare.Apis.Models.Cita", b =>
                {
                    b.Property<int>("IdCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCita"));

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMascota")
                        .HasColumnType("int");

                    b.Property<int>("IdServicio")
                        .HasColumnType("int");

                    b.Property<int>("Mascota")
                        .HasColumnType("int");

                    b.Property<int?>("MascotaIdMascota")
                        .HasColumnType("int");

                    b.Property<int>("Servicio")
                        .HasColumnType("int");

                    b.Property<int?>("ServicioIdServicio")
                        .HasColumnType("int");

                    b.HasKey("IdCita");

                    b.HasIndex("MascotaIdMascota");

                    b.HasIndex("ServicioIdServicio");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("PetCare.Apis.Models.CitaProducto", b =>
                {
                    b.Property<int>("IdCitaProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCitaProducto"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdCita")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("Producto")
                        .HasColumnType("int");

                    b.Property<int?>("ProductoIdProducto")
                        .HasColumnType("int");

                    b.HasKey("IdCitaProducto");

                    b.HasIndex("IdCita");

                    b.HasIndex("ProductoIdProducto");

                    b.ToTable("CitaProductos");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Mascota", b =>
                {
                    b.Property<int>("IdMascota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMascota"));

                    b.Property<int>("ClienteIdCliente")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMascota");

                    b.HasIndex("ClienteIdCliente");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<int>("IdProveedor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<int>("ProveedorIdProveedor")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.HasIndex("ProveedorIdProveedor");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Proveedor", b =>
                {
                    b.Property<int>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProveedor"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProveedor");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Servicio", b =>
                {
                    b.Property<int>("IdServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdServicio"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.HasKey("IdServicio");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Cita", b =>
                {
                    b.HasOne("PetCare.Apis.Models.Mascota", null)
                        .WithMany("Citas")
                        .HasForeignKey("MascotaIdMascota");

                    b.HasOne("PetCare.Apis.Models.Servicio", null)
                        .WithMany("Citas")
                        .HasForeignKey("ServicioIdServicio");
                });

            modelBuilder.Entity("PetCare.Apis.Models.CitaProducto", b =>
                {
                    b.HasOne("PetCare.Apis.Models.Cita", "Cita")
                        .WithMany("CitaProductos")
                        .HasForeignKey("IdCita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetCare.Apis.Models.Producto", null)
                        .WithMany("CitaProductos")
                        .HasForeignKey("ProductoIdProducto");

                    b.Navigation("Cita");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Mascota", b =>
                {
                    b.HasOne("PetCare.Apis.Models.Cliente", "Cliente")
                        .WithMany("Mascotas")
                        .HasForeignKey("ClienteIdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Producto", b =>
                {
                    b.HasOne("PetCare.Apis.Models.Proveedor", "Proveedor")
                        .WithMany("Productos")
                        .HasForeignKey("ProveedorIdProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Cita", b =>
                {
                    b.Navigation("CitaProductos");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Cliente", b =>
                {
                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Mascota", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Producto", b =>
                {
                    b.Navigation("CitaProductos");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Proveedor", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("PetCare.Apis.Models.Servicio", b =>
                {
                    b.Navigation("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}
