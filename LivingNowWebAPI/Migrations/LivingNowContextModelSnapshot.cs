﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LivingNowWebAPI.Migrations
{
    [DbContext(typeof(LivingNowContext))]
    partial class LivingNowContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LivingNowWebAPI.Models.AccionVenta", b =>
                {
                    b.Property<int>("idAccionVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAccionVenta"));

                    b.Property<string>("nombreAccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAccionVenta");

                    b.ToTable("AccionesVenta");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Barrio", b =>
                {
                    b.Property<int>("idBarrio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idBarrio"));

                    b.Property<int>("idLocalidad")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idBarrio");

                    b.HasIndex("idLocalidad");

                    b.ToTable("Barrios");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Ciudad", b =>
                {
                    b.Property<int>("idCiudad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCiudad"));

                    b.Property<int>("idDepartamento")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCiudad");

                    b.HasIndex("idDepartamento");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Departamento", b =>
                {
                    b.Property<int>("idDepartamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idDepartamento"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idDepartamento");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Localidad", b =>
                {
                    b.Property<int>("idLocalidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idLocalidad"));

                    b.Property<int>("idCiudad")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idLocalidad");

                    b.HasIndex("idCiudad");

                    b.ToTable("Localidades");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Permiso", b =>
                {
                    b.Property<int>("idPermiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPermiso"));

                    b.Property<string>("nombrePermiso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPermiso");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Propiedad", b =>
                {
                    b.Property<int>("idPropiedad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPropiedad"));

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idBarrio")
                        .HasColumnType("int");

                    b.Property<int>("idTipoAccion")
                        .HasColumnType("int");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("precio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPropiedad");

                    b.HasIndex("idBarrio");

                    b.HasIndex("idTipoAccion");

                    b.HasIndex("idUsuario");

                    b.ToTable("Propiedades");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Rol", b =>
                {
                    b.Property<int>("idRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idRol"));

                    b.Property<string>("nombreRol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.TipoAccion", b =>
                {
                    b.Property<int>("idTipoAccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idTipoAccion"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTipoAccion");

                    b.ToTable("TiposAccion");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"));

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idRol")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.HasIndex("idRol");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Barrio", b =>
                {
                    b.HasOne("LivingNowWebAPI.Models.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("idLocalidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Localidad");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Ciudad", b =>
                {
                    b.HasOne("LivingNowWebAPI.Models.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("idDepartamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Localidad", b =>
                {
                    b.HasOne("LivingNowWebAPI.Models.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("idCiudad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Propiedad", b =>
                {
                    b.HasOne("LivingNowWebAPI.Models.Barrio", "Barrio")
                        .WithMany()
                        .HasForeignKey("idBarrio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LivingNowWebAPI.Models.TipoAccion", "TipoAccion")
                        .WithMany()
                        .HasForeignKey("idTipoAccion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LivingNowWebAPI.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barrio");

                    b.Navigation("TipoAccion");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("LivingNowWebAPI.Models.Usuario", b =>
                {
                    b.HasOne("LivingNowWebAPI.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("idRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}
