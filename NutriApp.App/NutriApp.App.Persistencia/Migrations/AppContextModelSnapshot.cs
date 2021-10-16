﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutriApp.App.Persistencia;

namespace NutriApp.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NutriApp.App.Dominio.Historial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Carbohidratos")
                        .HasColumnType("real");

                    b.Property<float>("Estatura")
                        .HasColumnType("real");

                    b.Property<float>("Grasas")
                        .HasColumnType("real");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<float>("Proteinas")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("Historiales");
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Seguimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("HistorialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistorialId")
                        .IsUnique();

                    b.ToTable("Seguimientos");
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Coach", b =>
                {
                    b.HasBaseType("NutriApp.App.Dominio.Persona");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Coach_Especializacion");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Coach_TarjetaProfesional");

                    b.HasDiscriminator().HasValue("Coach");
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Nutricionista", b =>
                {
                    b.HasBaseType("NutriApp.App.Dominio.Persona");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Nutricionista");
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Paciente", b =>
                {
                    b.HasBaseType("NutriApp.App.Dominio.Persona");

                    b.Property<int?>("CoachId")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NutricionistaId")
                        .HasColumnType("int");

                    b.HasIndex("CoachId");

                    b.HasIndex("NutricionistaId");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Historial", b =>
                {
                    b.HasOne("NutriApp.App.Dominio.Paciente", null)
                        .WithMany("Historial")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Seguimiento", b =>
                {
                    b.HasOne("NutriApp.App.Dominio.Historial", null)
                        .WithOne("Seguimiento")
                        .HasForeignKey("NutriApp.App.Dominio.Seguimiento", "HistorialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Paciente", b =>
                {
                    b.HasOne("NutriApp.App.Dominio.Coach", "Coach")
                        .WithMany("Pacientes")
                        .HasForeignKey("CoachId");

                    b.HasOne("NutriApp.App.Dominio.Nutricionista", null)
                        .WithMany("Pacientes")
                        .HasForeignKey("NutricionistaId");

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Historial", b =>
                {
                    b.Navigation("Seguimiento");
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Coach", b =>
                {
                    b.Navigation("Pacientes");
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Nutricionista", b =>
                {
                    b.Navigation("Pacientes");
                });

            modelBuilder.Entity("NutriApp.App.Dominio.Paciente", b =>
                {
                    b.Navigation("Historial");
                });
#pragma warning restore 612, 618
        }
    }
}